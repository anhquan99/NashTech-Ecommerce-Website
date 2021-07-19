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

        // GET api/<CategoryApi>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryApi>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoryApi>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryApi>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
