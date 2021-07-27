using Ecomerece_Web.Data;
using Ecomerece_Web.Data.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Adapter
{
    public class ProductAdapter : IAdapter<Product, ProductPrototype>
    {
        public ProductPrototype convertFromOriginToProtoType(Product p)
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
        public Product convertFromProtoTypeToOriginal(ProductPrototype p)
        {
            return new Product()
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
                brand = new Brand() { brandNameID = p.brand },
                color = new Color() { colorNameID = p.color },
                category = new Category() { categoryNameID = p.category },
                type = new Data.Type() { typeNameID = p.type },
                silhouette = new Silhouette() { silhouetteNameID = p.silhouette },
                images = p.images,
                colorWay = p.colorWay,
                story = p.story
            };
        }
    }
}
