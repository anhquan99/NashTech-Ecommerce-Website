using Ecomerece_Web.Data;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Implement
{
    public class ProductService : BaseService<Product>, IProductRepository<Product>
    {
        public ProductService(ApplicationDbContext dbContext) : base(dbContext) { }
        public bool create(Product t)
        {
            try
            {
                this.objectSet.Add(t);
                return true;
            }
            catch(Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw ;
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
            catch(Exception e)
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
                return dbContext.products.Include(x => x.brand.brandNameID.ToLower() == brand.ToLower()).ToList();
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
                return objectSet.Include(x => x.category.categoryNameID.ToLower() == category.ToLower()).ToList();
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
                return objectSet.Include(x => x.color.colorNameID.ToLower() == color.ToLower()).ToList();
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
                return objectSet.Single(x => x.productNameID == id);
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
                return objectSet.Include(x => x.upperMaterial.ToLower() == material.ToLower()).ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public List<Product> findByReleaseDateOrderDesc()
        {
            try{
                return objectSet.OrderByDescending(x => x.releaseDate).ToList();
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
                return objectSet.Include(x => x.silhouette.silhouetteNameID.ToLower() == silhouette.ToLower()).ToList();
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
                return objectSet.Include(x => x.type.typeNameID.ToLower() == type.ToLower()).ToList();
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
                return objectSet.Include(x => x.type.typeNameID.ToLower() == type.ToLower() && x.brand.brandNameID == brand.ToLower()).ToList();
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
                return objectSet.OrderByDescending(x => x.rating).Take(20).ToList();
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
                return objectSet.OrderByDescending(x => x.view).Take(20).ToList();
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
    }
}
