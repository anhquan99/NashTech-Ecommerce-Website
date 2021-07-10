using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Discover()
        {
            return View();
        }
        [Route("/Sneaker/{ProductName}")]
        [Route("/Appearance/{ProductName}")]
        public IActionResult Detail( String ProductName)
        {
            Ecomerece_Web.Data.Product product = new Data.Product();
            List<Ecomerece_Web.Data.Product> list = new List<Data.Product>();
            (Ecomerece_Web.Data.Product, List<Ecomerece_Web.Data.Product>) data = (product, list);
            return View(data);
        }
    }
}
 