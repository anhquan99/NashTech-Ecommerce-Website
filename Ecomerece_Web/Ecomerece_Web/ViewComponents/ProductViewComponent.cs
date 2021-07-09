using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Views.Shared.Components.AuthenticateForm
{
    public class ProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(String type)
        {
            if (type.ToLower() == "default") return View();
            else return View("RankingProduct");
        }
    }
}
