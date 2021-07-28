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
    public class ColorApi : ControllerBase
    {
        private readonly IRepository<Color> colorService;
        public ColorApi(IRepository<Color> service)
        {
            this.colorService = service;
        }


        // GET: api/<SilHoutteApi>
        [HttpGet]
        public IEnumerable<Color> Get()
        {
            return colorService.findAll();
        }
    }
}
