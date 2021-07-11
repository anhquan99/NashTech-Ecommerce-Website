using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Interfaces
{
    interface IProductRepository<T> : IRepository<T>
    {
        List<T> findByReleaseDateOrderDesc();
        List<T> findByMaterial(String material);
        List<T> findByColor(String color);
        List<T> findByBrand(String brand);
        List<T> findByCategory(String category);
        List<T> findByType(String type);
        List<T> findByTypeAndBrand(String type, String brand);
        List<T> findBySilhouette(String silhouette);
        List<T> topView();
        List<T> topRating();
        
    }
}
