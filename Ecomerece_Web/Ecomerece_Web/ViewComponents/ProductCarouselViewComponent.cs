using Ecomerece_Web.Data;
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
            (List<Product>, String, String) data = (products, name, url);
            return View(data);
        }
    }
}
