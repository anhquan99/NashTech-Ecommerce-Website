using Ecomerece_Web.Data;
using Ecomerece_Web.Services;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ProductController : Controller
    {
        private readonly IRepository<Product> productService;
        public ProductController(IProductRepository<Product> productService)
        {
            this.productService = productService; 
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Discover()
        {
            return View();
        }
        [Route("/Product/{ProductName}")]
        public IActionResult Detail( String ProductName)
        {
            Ecomerece_Web.Data.Product product = productService.findByID(ProductName);
            List<Ecomerece_Web.Data.Product> list = new List<Data.Product>();
            (Ecomerece_Web.Data.Product, List<Ecomerece_Web.Data.Product>) data = (product, list);
            return View(data);
        }
        [Route("/Product/Brand/{brand}")]
        public IActionResult Brand(String brand)
        {
            return View();
        }
    }
}
 