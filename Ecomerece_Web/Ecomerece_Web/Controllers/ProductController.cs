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
        [Route("/{Type}/{ProductName}")]
        public IActionResult Detail(String Type, String ProductName)
        {
            return View();
        }
    }
}
 