using Ecomerece_Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services
{
    public static class IQueryableExtensions
    {
        public static IQueryable<Product> getReleasedProduct(this IQueryable<Product> source)
        {
            return source.Where(p => p.releaseDate <= DateTime.Now);
        }
        public static IQueryable<Product> includeAll(this IQueryable<Product> source)
        {
            return source.Select(p => new Product
            {
                productNameID = p.productNameID,
                releaseDate = p.releaseDate,
                upperMaterial = p.upperMaterial,
                colorWay = p.colorWay,
                story = p.story,
                price = p.price,
                wallpaper = p.wallpaper,
                view = p.view,
                rating = p.rating,
                coverImg = p.coverImg,
                brand = new Brand() { brandNameID = p.brand.brandNameID },
                color = new Color() { colorNameID = p.color.colorNameID },
                category = new Category() { categoryNameID = p.category.categoryNameID },
                type = new Data.Type() { typeNameID = p.type.typeNameID },
                silhouette = new Silhouette() { silhouetteNameID = p.silhouette.silhouetteNameID },
                usedPrice = p.usedPrice,
                images = p.images
            });
        }
        /// <summary>
        /// use for expression
        /// </summary>
        /// <returns></returns>
        public static System.Linq.Expressions.Expression<Func<Product, bool>> isReleased()
        {
            return p => p.releaseDate <= DateTime.Now;
        }
        public static System.Linq.Expressions.Expression<Func<Product, bool>> isSneaker()
        {
            return p => p.type.typeNameID == "Sneaker";
        }
        public static IQueryable<Product> Page(this IQueryable<Product> source, int page, int pageSize)
        {
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
}
