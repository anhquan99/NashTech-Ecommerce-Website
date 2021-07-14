using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Interfaces
{
    public interface IProductRepository<T> : IRepository<T>
    {
        // for admin
        public List<T> findByMaterial(String material);
        public List<T> findByColor(String color);
        public List<T> findByBrand(String brand);
        public List<T> findByCategory(String category);
        public List<T> findByType(String type);
        public List<T> findByTypeAndBrand(String type, String brand);
        public List<T> findBySilhouette(String silhouette);
        // for user
        public List<T> getAllReleaseDateOrderDesc(int page,int size);
        public List<T> topView();
        public List<T> topRating();
        public List<T> findByBrandWithTypeAndReleaseDateOrderDesc(String brand, String type);
        public List<T> findBySilhouetteWithReleaseDateOrderDesc(String silhouette);
        public List<T> findByBranWithAndReleaseDate(String brand);
        public List<T> top20Treding();
        public List<T> mostWanted();
        public List<T> findByYearWithReleaseDateOrderDesc(int year);
        public T getCoverProductWithOrderDesc();



    }
}
