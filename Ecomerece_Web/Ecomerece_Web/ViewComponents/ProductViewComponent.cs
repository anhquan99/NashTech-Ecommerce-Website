using Ecomerece_Web.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Views.Shared.Components.AuthenticateForm
{
    public class ProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Product product,String type = "default", int rank = 0 )
        {
            if (type.ToLower() == "default") return View(product);
            else if(type.ToLower() == "ranking")
            {
                (Product product, int rank) data = ( product, rank);
                return View("RankingProduct", data);
            }
            else
            {
                return View("ProductCover", product);
            }
        }
    }
}
