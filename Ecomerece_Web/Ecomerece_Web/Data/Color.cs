using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Data
{
    public class Color
    {
        [Key]
        public String colorNameID { set; get; }
        public List<Product> products { set; get; }
    }
}
