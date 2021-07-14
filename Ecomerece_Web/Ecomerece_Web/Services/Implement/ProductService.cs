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

        public List<Product> findByBrand(string brand)
        {
            try
            {
                return dbContext.products.Where(x => x.brand.brandNameID.ToLower() == brand.ToLower()).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> findByCategory(string category)
        {
            try
            {
                return objectSet.Where(x => x.category.categoryNameID.ToLower() == category.ToLower()).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> findByColor(string color)
        {
            try
            {
                return objectSet.Where(x => x.color.colorNameID.ToLower() == color.ToLower()).ToList();
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

        public List<Product> findByMaterial(string material)
        {
            try
            {
                return objectSet.Where(x => x.upperMaterial.ToLower() == material.ToLower()).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> getAllReleaseDateOrderDesc(int page, int size)
        {
            try
            {
                return objectSet.getReleasedProduct().OrderByDescending(x => x.releaseDate).Page(page,size).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> findBySilhouette(string silhouette)
        {
            try
            {
                return objectSet.Where(x => x.silhouette.silhouetteNameID.ToLower() == silhouette.ToLower()).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> findByType(string type)
        {
            try
            {
                return objectSet.Where(x => x.type.typeNameID.ToLower() == type.ToLower()).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> findByTypeAndBrand(string type, string brand)
        {
            try
            {
                return objectSet.Where(x => x.type.typeNameID.ToLower() == type.ToLower() && x.brand.brandNameID == brand.ToLower()).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> topRating()
        {
            try
            {
                return objectSet.getReleasedProduct().OrderByDescending(x => x.rating).Take(20).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> topView()
        {
            try
            {
                return objectSet.getReleasedProduct().OrderByDescending(x => x.view).Take(20).ToList();
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

        public List<Product> findByBrandWithTypeAndReleaseDateOrderDesc(string brand, string type)
        {
            try
            {
                return objectSet.getReleasedProduct().Where(p => p.brand.brandNameID.ToLower() == brand.ToLower() && p.type.typeNameID.ToLower() == type.ToLower()).OrderByDescending(p => p.releaseDate).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> findBySilhouetteWithReleaseDateOrderDesc(string silhouette)
        {
            try
            {
                return objectSet.getReleasedProduct().Where(p => p.silhouette.silhouetteNameID.ToLower() == silhouette.ToLower()).OrderByDescending(p => p.releaseDate).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> findByBranWithAndReleaseDate(string brand)
        {
            try
            {
                return objectSet.getReleasedProduct().Where(p => p.brand.brandNameID.ToLower() == brand.ToLower()).OrderByDescending(p => p.releaseDate).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> top20Treding()
        {
            try
            {
                return objectSet.getReleasedProduct().OrderByDescending(p => p.releaseDate).ThenBy(p => p.view).Take(20).ToList();
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
        public List<Product> mostWanted()
        {
            try
            {
                return objectSet.getReleasedProduct().OrderByDescending(p => p.releaseDate).ThenBy(p => p.view).Take(20).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> findByYearWithReleaseDateOrderDesc(int year)
        {
            try
            {
                return objectSet.Where(p => p.releaseDate.Year == year).OrderByDescending(p => p.releaseDate).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }
        /// <summary>
        /// return single item
        /// </summary>
        /// <returns></returns>
        public Product getCoverProductWithOrderDesc()
        {
            try
            {
                var temp = objectSet.Where(p => !String.IsNullOrEmpty(p.wallpaper)).FirstOrDefault();
                return temp;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }





    }
    public static class IQueryableExtensions
    {
        /// <summary>
        /// use query
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IQueryable<Product> getReleasedProduct(this IQueryable<Product> source)
        {
            return source.Where(p => p.releaseDate <= DateTime.Now);
        }
        public static IQueryable<Product> includeAll(this IQueryable<Product> source)
        {
            return source.Include(p => p.brand)
                           .Include(p => p.category)
                           .Include(p => p.color)
                           .Include(p => p.images)
                           .Include(p => p.silhouette)
                           .Include(p => p.type);
        }
        /// <summary>
        /// use for expression
        /// </summary>
        /// <returns></returns>
        public static System.Linq.Expressions.Expression<Func<Product, bool>> isReleased()
        {
            return p => p.releaseDate <= DateTime.Now;
        }
        public static IQueryable<Product> Page(this IQueryable<Product> source, int page, int pageSize)
        {
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}
