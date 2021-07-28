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
    public class BrandApi : ControllerBase
    {
        private readonly IRepository<Brand> brandService;
        public BrandApi(IRepository<Brand> service)
        {
            this.brandService = service;
        }


        // GET: api/<SilHoutteApi>
        [HttpGet]
        public IEnumerable<Brand> Get()
        {
            return brandService.findAll();
        }
    }
}
