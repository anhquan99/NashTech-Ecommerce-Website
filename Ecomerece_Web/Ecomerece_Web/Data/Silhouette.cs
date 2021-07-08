using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Data
{
    public class Silhouette
    {
        public int id { get; set; }
        [Required]
        public String name { set; get; }
        public List<Product> products { get; set; }
    }
}
