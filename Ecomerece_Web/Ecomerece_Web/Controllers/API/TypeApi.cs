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
    public class TypeApi : ControllerBase
    {
        private readonly IRepository<Ecomerece_Web.Data.Type> typeService;
        public TypeApi(IRepository<Ecomerece_Web.Data.Type> service)
        {
            this.typeService = service;
        }
        // GET: api/<SilHoutteApi>
        [HttpGet]
        public IEnumerable<Ecomerece_Web.Data.Type> Get()
        {
            return typeService.findAll();
        }

        // GET api/<TypeApi>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TypeApi>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TypeApi>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TypeApi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
