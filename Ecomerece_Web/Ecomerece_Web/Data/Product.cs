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
        [Required]
        public DateTime releaseDate { get; set; }
        public String upperMaterial { get; set; }
        [Required]
        public String colorWay { get; set; }
        public String story { get; set; }
        [Required]
        [Range(0.0, double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public double price { get; set; }
        [Range(0.0, double.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public double usedPrice { get; set; }
        public String wallpaper { get; set; }
        [Required]
        public int view { get; set; }
        [Range(0.0, 5.0)]
        public double rating { get; set; }
        [Required]
        public String coverImg { get; set; }
        [Required]
        public Brand brand { get; set; }
        [Required]
        public Color color { get; set; }
        [Required]
        public Category category { get; set; }
        [Required]
        public Ecomerece_Web.Data.Type type { get; set; }
        [Required]
        public Ecomerece_Web.Data.Silhouette silhouette {get;set;}
        [Required]      
        public List<Image> images { get; set; }
        public List<User> userWantProduct { get; set; }

        public Product()
        {
          
        }
    }
}
