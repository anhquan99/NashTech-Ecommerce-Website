using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Interfaces
{
    public interface IProductRepository<T> : IRepository<T>
    {
        // for admin
        public IQueryable<T> findByMaterial(String material);
        public IQueryable<T> findByColor(String color);
        public IQueryable<T> findByBrand(String brand);
        public IQueryable<T> findByCategory(String category);
        public IQueryable<T> findByType(String type);
        public IQueryable<T> findByTypeAndBrand(String type, String brand);
        public IQueryable<T> findBySilhouette(String silhouette);
        // for user and sneaker 
        public IQueryable<T> getAllReleaseDateOrderDesc();
        public IQueryable<T> topView();
        public IQueryable<T> topRating();
        public IQueryable<T> findBySilhouetteWithReleaseDateOrderDesc(String silhouette);
        public IQueryable<T> findByBrandAndReleaseDate(String brand);
        public IQueryable<T> topTrending();
        public IQueryable<T> mostWanted();
        public IQueryable<T> findByYearWithReleaseDateOrderDesc(int year);
        public T getCoverProductWithOrderDesc();
        public IQueryable<T> getAllReleasedInYear(int year);

        // clothing 
        public IQueryable<T> findByBrandWithTypeAndReleaseDateOrderDesc(String brand);

    }
}
