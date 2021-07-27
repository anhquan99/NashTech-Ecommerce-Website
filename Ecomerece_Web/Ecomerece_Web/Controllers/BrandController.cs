using Ecomerece_Web.Data;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class BrandController : Controller
    {
        private readonly IProductRepository<Product> productService;
        public BrandController(IProductRepository<Product> service)
        {
            this.productService = service;
        }
        [Route("/Brand/{brand}")]
        public IActionResult Index(String brand)
        {
            var temp = productService.findByBrandAndReleaseDate(brand).ToList();
            (String, List<Product>) data = (brand, temp);
            return View(data);
        }
    }
}
