using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Data
{
    public class Silhouette
    {
        [Key]
        public String silhouetteNameID { get; set; }
        public List<Product> products { get; set; }

        public Silhouette()
        {
        }
    }
}
