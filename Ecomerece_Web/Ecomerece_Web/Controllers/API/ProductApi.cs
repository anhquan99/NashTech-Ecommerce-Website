﻿using Ecomerece_Web.Data;
using Ecomerece_Web.Data.Prototype;
using Ecomerece_Web.Models;
using Ecomerece_Web.Services;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecomerece_Web.Controllers.API
{
    [Route("api/Product")]
    [ApiController]
    public class ProductApi : ControllerBase
    {
        private readonly IProductRepository<Product> productService;
        public ProductApi(IProductRepository<Product> service)
        {
            this.productService = service;
        }
        // GET: api/<ProductApi>
        //[Authorize]
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productService.findAll();
        }

        // GET api/<ProductApi>/5
        [HttpGet("{id}")]
        public Product Get(String id)
        {
            return productService.findByID(id);
        }
        [HttpGet("getpage/{page}")]
        public IEnumerable<Product> GetPage(int page)
        {
            return productService.getAllReleaseDateOrderDesc(page, 10);
        }
        // POST api/<ProductApi>
        [HttpPost]
        public void Post([FromForm] ProductPrototype product)
        {
            //Console.WriteLine(product.ToString());

        }

        // PUT api/<ProductApi>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductPrototype product)
        {

        }

        // DELETE api/<ProductApi>/5
        [HttpDelete("{id}")]
        public void Delete(String id)
        {
            productService.delete(id);
        }
    }
}