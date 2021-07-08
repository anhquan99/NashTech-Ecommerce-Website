using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Data
{
    public class Color
    {
        public int id { set; get; }
        [Required]
        public String name { set; get; }
        public List<Product> products { set; get; }
    }
}
