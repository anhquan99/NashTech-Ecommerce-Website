using Ecomerece_Web.Data;
using Ecomerece_Web.Data.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Adapter
{
    public class ProductAdapter
    {
        public static ProductPrototype convertFromProductToProductType(Product p)
        {
            return new ProductPrototype()
            {
                productNameID = p.productNameID,
                releaseDate = p.releaseDate,
                upperMaterial = p.upperMaterial,
                price = p.price,
                usedPrice = p.usedPrice,
                wallpaper = p.wallpaper,
                view = p.view,
                rating = p.rating,
                coverImg = p.coverImg,
                brand = p.brand.brandNameID,
                color = p.color.colorNameID,
                category = p.category.categoryNameID,
                type = p.type.typeNameID,
                silhouette = p.silhouette.silhouetteNameID,
                images = p.images,
                colorWay = p.colorWay,
                story = p.story
            };
        }
    }
}
