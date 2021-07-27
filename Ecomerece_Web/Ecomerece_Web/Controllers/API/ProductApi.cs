using Ecomerece_Web.Data;
using Ecomerece_Web.Data.Prototype;
using Ecomerece_Web.Models;
using Ecomerece_Web.Services;
using Ecomerece_Web.Services.Adapter;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecomerece_Web.Controllers.API
{
    [Route("api/Product")]
    [ApiController]
    public class ProductApi : ControllerBase
    {
        private readonly IProductRepository<Product> productService;
        private readonly IAdapter<Product, ProductPrototype> productAdapter;
        private readonly FileService fileService;
        public ProductApi(IProductRepository<Product> service, IAdapter<Product, ProductPrototype> productAdapter, FileService fileService)
        {
            this.productService = service;
            this.productAdapter = productAdapter;
            this.fileService = fileService;
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
        public ActionResult<ProductPrototype> Get(String id)
        {
            var data = productService.findByID(id);

            if (data != null) return productAdapter.convertFromOriginToProtoType(data);
            else
            {
                return NotFound();
            }
        }
        [HttpGet("getpage/{page}")]
        public IEnumerable<Product> GetPage(int page)
        {
            return IQueryableExtensions.Page(productService.getAllReleaseDateOrderDesc(), page, 10);
        }
        // POST api/<ProductApi>
        [HttpPost]
        public void Post([FromForm] ProductPrototype product)
        {
            Product newProduct = productAdapter.convertFromProtoTypeToOriginal(product);
            product.coverImg = product.coverImagePost.FileName;
            product.wallpaper = product.wallpaperImagePost.FileName;
            product.images.Add(new Image { imageNameID = product.coverImg });
            foreach (var i in product.imagesPost)
            {
                product.images.Add(new Image { imageNameID = i.FileName });
            }
            fileService.uploadMultiFile(product.imagesPost);
            fileService.uploadFile(product.coverImagePost);
            if (product.wallpaperImagePost != null)
            {
                fileService.uploadFile(product.wallpaperImagePost);

            }
            newProduct = productAdapter.convertFromProtoTypeToOriginal(product);
            productService.create(newProduct);
        }

        // PUT api/<ProductApi>/5
        [HttpPut("{id}")]
        public void Put(String id, [FromForm] ProductPrototype product, [FromForm] List<String> oldFiles)
        {
            var oldProduct = productService.findByID(id);
            List<String> originOldFile = oldProduct.images.Select(x => x.imageNameID).ToList();
            List<String> deleteFile = (List<string>)originOldFile.Except(oldFiles);
            // delete old file has been removed
            foreach (var i in deleteFile)
            {
                fileService.deleteFile(i);
            }
            // if cover img is changed
            if (oldProduct.coverImg != product.coverImagePost.FileName)
            {
                product.coverImg = product.coverImagePost.FileName;
                fileService.deleteFile(oldProduct.coverImg);
                product.images.Add(new Image { imageNameID = product.coverImg });
            }
            // if wallpaper is changed
            if (oldProduct.wallpaper != product.wallpaperImagePost.FileName)
            {
                if (!String.IsNullOrEmpty(oldProduct.wallpaper))
                {
                    fileService.deleteFile(oldProduct.wallpaper);
                }
                fileService.uploadFile(product.wallpaperImagePost);
                product.wallpaper = product.wallpaperImagePost.FileName;
            }

            foreach (var i in product.imagesPost)
            {
                product.images.Add(new Image { imageNameID = i.FileName });
            }
            fileService.uploadMultiFile(product.imagesPost);
            fileService.uploadFile(product.coverImagePost);
            var tempOriginal = productAdapter.convertFromProtoTypeToOriginal(product);
            productService.update(tempOriginal);
        }

        // DELETE api/<ProductApi>/5
        [HttpDelete("{id}")]
        public void Delete(String id)
        {
            var product = productService.findByID(id);
            foreach (var i in product.images)
            {
                fileService.deleteFile(i.imageNameID);
            }
            fileService.deleteFile(product.coverImg);
            if (String.IsNullOrEmpty(product.wallpaper))
            {
                fileService.deleteFile(product.wallpaper);
            }

            productService.delete(id);
        }
    }
}
