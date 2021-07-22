using Ecomerece_Web.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Data.Prototype
{
    public class ProductPrototype
    {
        public String productNameID { get; set; }
        public DateTime releaseDate { get; set; }
        public String upperMaterial { get; set; }
        public String colorWay { get; set; }
        public String story { get; set; }
        public double price { get; set; }
        public double usedPrice { get; set; }
        public String wallpaper { get; set; }
        public int view { get; set; }
        public double rating { get; set; }
        public String coverImg { get; set; }
        public String brand { get; set; }
        public String color { get; set; }
        public String category { get; set; }
        public String type { get; set; }
        public String silhouette { get; set; }
        public List<Image> images{get;set; }

        public List<IFormFile> imagesPost { get; set; }
        public IFormFile coverImagePost { get; set; }
        public IFormFile wallpaperImagePost { get; set; }

    }
}
