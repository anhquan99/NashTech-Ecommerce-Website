using Ecomerece_Web.Data;
using Ecomerece_Web.Models;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository<Product> productService;
        public HomeController(ILogger<HomeController> logger, IProductRepository<Product> productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            //Seed.SeedProduct(productService);
            var coverProduct = productService.getCoverProductWithOrderDesc();
            var topTreding = productService.top20Treding();
            var mostWanted = productService.mostWanted();
            // list collection
            // colection product list
            (Product, List<Product>, List<Product>) data = (coverProduct, topTreding, mostWanted);
            return View(data);
        }
        public IActionResult TimeLine()
        {
            return View();
        }
        public IActionResult ShopAll()
        {
            
            return View() ;
        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
