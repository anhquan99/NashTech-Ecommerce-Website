using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Data
{
    public class Category
    {
        public int id { get; set; } 
        [Required]
        public String name { get; set; }
        public List<Product> products { get; set; }
        
    }
}
