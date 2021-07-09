using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Data
{
    public class Product
    {
        [Key]
        public String productNameID { get; set; }
        public DateTime releaseDate { get; set; }
        public String upperMaterial { get; set; }
        [Required]
        public String colorWay { get; set; }
        public String story { get; set; }
        [Required]
        public double price { get; set; }
        public String wallpaper { get; set; }
        public Brand brand { get; set; }
        public Color color { get; set; }
        public Category category { get; set; }
        public Ecomerece_Web.Data.Type type { get; set; }
        public Ecomerece_Web.Data.Silhouette silhouette {get;set;}
      
        public List<Image> images { get; set; }
    }
}
