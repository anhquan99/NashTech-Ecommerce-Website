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
            if (productService.findByID(product.productNameID) != null) return;

            Product newProduct = productAdapter.convertFromProtoTypeToOriginal(product);

            // handle coverImg
            product.coverImg = product.coverImagePost.FileName;
            fileService.uploadFile(product.coverImagePost).Wait();

            product.images = new List<Image>();
            foreach (var i in product.imagesPost)
            {
                product.images.Add(new Image { imageNameID = i.FileName });
            }
            fileService.uploadMultiFile(product.imagesPost).Wait();
            if (product.wallpaperImagePost != null)
            {
                product.wallpaper = product.wallpaperImagePost.FileName;
                fileService.uploadFile(product.wallpaperImagePost).Wait();

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
            List<String> deleteFile = originOldFile.Where(p => oldFiles.All(i => i == p)).ToList();
            // delete old file has been removed
            foreach (var i in deleteFile)
            {
                fileService.deleteFile(i).Wait();
            }
            productService.updateDeletImage(deleteFile, oldProduct.productNameID);
            // if cover img is changed
            if (product.coverImagePost != null)
            {
                product.coverImg = product.coverImagePost.FileName;
                fileService.deleteFile(oldProduct.coverImg).Wait();
                fileService.uploadFile(product.coverImagePost).Wait();
            }
            // if wallpaper is changed
            if (product.wallpaperImagePost != null)
            {
                if (!String.IsNullOrEmpty(oldProduct.wallpaper))
                {
                    fileService.deleteFile(oldProduct.wallpaper).Wait();
                }
                fileService.uploadFile(product.wallpaperImagePost).Wait();
                product.wallpaper = product.wallpaperImagePost.FileName;
            }
            product.images = new List<Image>();
            if (product.imagesPost != null)
            {
                foreach (var i in product.imagesPost)
                {
                    product.images.Add(new Image { imageNameID = i.FileName });
                }
                fileService.uploadMultiFile(product.imagesPost).Wait();

            }
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
                fileService.deleteFile(i.imageNameID).Wait();
            }
            if (!String.IsNullOrEmpty(product.wallpaper))
            {
                fileService.deleteFile(product.wallpaper).Wait();
            }

            productService.delete(id);
        }
    }
}
