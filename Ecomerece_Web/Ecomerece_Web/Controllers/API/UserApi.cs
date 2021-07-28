using Ecomerece_Web.Data;
using Ecomerece_Web.Data.Prototype;
using Ecomerece_Web.Services.Adapter;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecomerece_Web.Controllers.API
{
    //[Authorize("admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserApi : ControllerBase
    {
        private readonly IUserRepository<User> userService;
        private readonly IAdapter<User, UserPrototype> userAdapter;
        public UserApi(IUserRepository<User> userService, IAdapter<User, UserPrototype> userAdapter)
        {
            this.userService = userService;
            this.userAdapter = userAdapter;
        }
        // GET: api/<UserApi>
        [HttpGet]
        public IEnumerable<UserPrototype> Get()
        {
            List<UserPrototype> data = new List<UserPrototype>();
            foreach (var i in userService.findAll())
            {
                data.Add(userAdapter.convertFromOriginToProtoType(i));
            }
            return data;
        }
        [HttpGet]
        [Route("getadmin")]
        public IEnumerable<UserPrototype> GetAdmin()
        {
            List<UserPrototype> data = new List<UserPrototype>();
            foreach (var i in userService.findAllAdmin())
            {
                data.Add(userAdapter.convertFromOriginToProtoType(i));
            }
            return data;
        }
        // GET api/<UserApi>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<UserApi>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<UserApi>/5
        [HttpPut("{email}")]
        public void Put(String email)
        {
            var user = userService.findByID(email);
            userService.update(user);
        }

        // DELETE api/<UserApi>/5
        [HttpDelete("{email}")]
        public void Delete(String email)
        {
            userService.delete(email);
        }
    }
}
