using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Data
{
    public class Image
    {
        public int id { get; set; }
        [Required]
        public String name { get; set; }
    }
}
