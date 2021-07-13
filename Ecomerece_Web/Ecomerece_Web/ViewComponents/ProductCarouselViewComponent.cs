using Ecomerece_Web.Data;
using Ecomerece_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.ViewComponents
{
    public class ProductCarouselViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(List<Product> products, String name, String url = "")
        {
            ViewBag.id = RandomObject.randomString();
            (List<Product>, String, String) data = (products, name, url);
            return View(data);
        }
    }
}
