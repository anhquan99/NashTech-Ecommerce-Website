using Ecomerece_Web.Data;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.ViewComponents
{
    public class BrandViewComponent : ViewComponent
    {
        private readonly IRepository<Brand> brandService;
        public BrandViewComponent(IRepository<Brand> repository)
        {
            this.brandService = repository;
        }
        public IViewComponentResult Invoke()
        {
            var data = brandService.findAll();
            return View(data);
        }
    }
}
