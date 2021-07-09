using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Data
{
    public class Type
    {
        [Key]
        public String typeNameID { get; set; }  
        public List<Product> products { get; set; } 
    }
}
