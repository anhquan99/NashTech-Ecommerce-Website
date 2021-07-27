using Ecomerece_Web.Data;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Implements
{
    public class ProductService : BaseService<Product>, IProductRepository<Product>
    {
        public ProductService(ApplicationDbContext dbContext) : base(dbContext) { }
        public bool create(Product t)
        {
            try
            {
                var brand = dbContext.Set<Brand>().Find(t.brand.brandNameID);
                if (brand != null) t.brand = brand;
                var color = dbContext.Set<Color>().Find(t.color.colorNameID);
                if (color != null) t.color = color;
                var category = dbContext.Set<Category>().Find(t.category.categoryNameID);
                if (category != null) t.category = category;
                var type = dbContext.Set<Ecomerece_Web.Data.Type>().Find(t.type.typeNameID);
                if (type != null) t.type = type;
                var silhoutte = dbContext.Set<Silhouette>().Find(t.silhouette.silhouetteNameID);
                if (silhoutte != null) t.silhouette = silhoutte;

                this.objectSet.Add(t);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public bool delete(string id)
        {
            try
            {
                var item = objectSet.Single(x => x.productNameID == id);
                objectSet.Remove(item);
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> findAll()
        {
            try
            {
                return objectSet.ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findByBrand(string brand)
        {
            try
            {
                return dbContext.products.Where(x => x.brand.brandNameID.ToLower() == brand.ToLower());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findByCategory(string category)
        {
            try
            {
                return objectSet.Where(x => x.category.categoryNameID.ToLower() == category.ToLower());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findByColor(string color)
        {
            try
            {
                return objectSet.Where(x => x.color.colorNameID.ToLower() == color.ToLower());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public Product findByID(string id)
        {
            try
            {
                return objectSet.Where(x => x.productNameID == id)
                    .includeAll()
                    .SingleOrDefault();

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findByMaterial(string material)
        {
            try
            {
                return objectSet.Where(x => x.upperMaterial.ToLower() == material.ToLower());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> getAllReleaseDateOrderDesc()
        {
            try
            {
                return objectSet.getReleasedProduct()
                    .OrderByDescending(x => x.releaseDate)
                    .Where(IQueryableExtensions.isSneaker());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findBySilhouette(string silhouette)
        {
            try
            {
                return objectSet.Where(x => x.silhouette.silhouetteNameID.ToLower() == silhouette.ToLower());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findByType(string type)
        {
            try
            {
                return objectSet.Where(x => x.type.typeNameID.ToLower() == type.ToLower());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findByTypeAndBrand(string type, string brand)
        {
            try
            {
                return objectSet.Where(x => x.type.typeNameID.ToLower() == type.ToLower() && x.brand.brandNameID == brand.ToLower());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> topRating()
        {
            try
            {
                return objectSet.getReleasedProduct()
                    .OrderByDescending(x => x.rating)
                    .Where(IQueryableExtensions.isSneaker()).Take(20);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> topView()
        {
            try
            {
                return objectSet.getReleasedProduct()
                    .OrderByDescending(x => x.view)
                    .Where(IQueryableExtensions.isSneaker()).Take(20);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public bool update(Product t)
        {
            try
            {
                var item = objectSet.Single(x => x.productNameID == t.productNameID);

                item.releaseDate = t.releaseDate;
                item.upperMaterial = t.upperMaterial;
                item.colorWay = t.colorWay;
                item.story = t.story;
                item.price = t.price;
                item.wallpaper = t.wallpaper;
                item.brand = t.brand;
                item.color = t.color;
                item.category = t.category;
                item.type = t.type;
                item.silhouette = t.silhouette;
                item.rating = t.rating;
                item.view = t.view;
                item.coverImg = t.coverImg;

                dbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findByBrandWithTypeAndReleaseDateOrderDesc(string brand)
        {
            try
            {
                return objectSet.getReleasedProduct()
                    .Where(p => p.brand.brandNameID.ToLower() == brand.ToLower())
                    .OrderByDescending(p => p.releaseDate);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findBySilhouetteWithReleaseDateOrderDesc(string silhouette)
        {
            try
            {
                return objectSet.getReleasedProduct()
                    .Where(p => p.silhouette.silhouetteNameID.ToLower() == silhouette.ToLower())
                    .Where(IQueryableExtensions.isSneaker())
                    .OrderByDescending(p => p.releaseDate);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findByBranWithAndReleaseDate(string brand)
        {
            try
            {
                return objectSet.getReleasedProduct()
                    .Where(p => p.brand.brandNameID.ToLower() == brand.ToLower())
                    .OrderByDescending(p => p.releaseDate);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> topTrending()
        {
            try
            {
                return objectSet.getReleasedProduct()
                    .OrderByDescending(p => p.releaseDate)
                    .ThenBy(p => p.view).Where(p => p.releaseDate.Year == DateTime.Now.Year);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }

        }
        /// <summary>
        /// only return 20 item
        /// </summary>
        /// <returns></returns>
        public IQueryable<Product> mostWanted()
        {
            try
            {
                return objectSet.getReleasedProduct()
                    .Where(IQueryableExtensions.isSneaker())
                    .OrderByDescending(p => p.releaseDate)
                    .ThenBy(p => p.view).Take(20);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findByYearWithReleaseDateOrderDesc(int year)
        {
            try
            {
                return objectSet.Where(p => p.releaseDate.Year == year)
                    .OrderByDescending(p => p.releaseDate);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }
        public Product getCoverProductWithOrderDesc()
        {
            try
            {
                var temp = objectSet.Where(p => !String.IsNullOrEmpty(p.wallpaper))
                    .Where(IQueryableExtensions.isSneaker())
                    .FirstOrDefault();
                return temp;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> getAllReleasedInYear(int year)
        {
            try
            {
                return objectSet.getReleasedProduct()
                    .OrderByDescending(p => p.releaseDate)
                    .ThenBy(p => p.view).Where(p => p.releaseDate.Year == year)
                    ;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public IQueryable<Product> findByBrandAndReleaseDate(string brand)
        {
            try
            {
                return objectSet.getReleasedProduct()
                    .Where(p => p.brand.brandNameID.ToLower() == brand.ToLower())
                    .Where(IQueryableExtensions.isSneaker()).OrderByDescending(p => p.releaseDate)
                    ;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }
    }
}
