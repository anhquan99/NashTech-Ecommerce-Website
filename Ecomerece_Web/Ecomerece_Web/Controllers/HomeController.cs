using Ecomerece_Web.Data;
using Ecomerece_Web.Models;
using Ecomerece_Web.Services;
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
    [ApiExplorerSettings(IgnoreApi = true)]
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
            var topTreding = productService.topTrending().Take(12).ToList();
            var mostWanted = productService.mostWanted().Take(10).ToList();
            var justDropped = IQueryableExtensions.Page(productService.getAllReleaseDateOrderDesc(), 1, 10).ToList();
            // list collection
            // colection product list
            (Product, List<Product>, List<Product>, List<Product>) data = (coverProduct, topTreding, mostWanted, justDropped);
            return View(data);
        }
        public IActionResult TimeLine()
        {
            Seed.SeedProduct(productService);
            return View();
        }
        [Route("/Home/ShopAll")]
        public IActionResult ShopAll()
        {
            var data = IQueryableExtensions.Page(productService.getAllReleaseDateOrderDesc(), 1, 8).ToList();
            ViewBag.page = 1;
            return View(data);
        }
        [Route("/Home/ShopAllPage/{page}")]
        public IActionResult ShopAllPage(int page)
        {
            var data = IQueryableExtensions.Page(productService.getAllReleaseDateOrderDesc(), page, 8).ToList();
            return ViewComponent("ProductList", new { products = data });
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
        public IActionResult JustDropped()
        {
            var justDropped = productService.getAllReleasedInYear(DateTime.Now.Year).ToList();
            // get products from current year 
            // get product now 
            return View(justDropped);
        }
        public IActionResult Top20Trending()
        {
            var top20Trending = productService.topTrending().ToList();
            return View(top20Trending);
        }
        public IActionResult MostWanted()
        {
            var mostWanted = productService.mostWanted().ToList();
            return View(mostWanted);
        }
    }
}
