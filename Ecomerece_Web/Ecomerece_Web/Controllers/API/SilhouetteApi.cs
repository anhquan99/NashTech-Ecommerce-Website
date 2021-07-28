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
    public class SilhouetteApi : ControllerBase
    {
        private readonly IRepository<Silhouette> silhouetteService;
        public SilhouetteApi(IRepository<Silhouette> service)
        {
            this.silhouetteService = service;
        }


        // GET: api/<SilHoutteApi>
        [HttpGet]
        public IEnumerable<Silhouette> Get()
        {
            return silhouetteService.findAll();
        }
    }
}
