using Ecomerece_Web.Data;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecomerece_Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryApi : ControllerBase
    {
        private readonly IRepository<Category> categoryService;
        public CategoryApi(IRepository<Category> service)
        {
            this.categoryService = service;
        }

        // GET: api/<SilHoutteApi>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return categoryService.findAll();
        }

    }
}
