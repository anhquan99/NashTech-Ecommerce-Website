using Ecomerece_Web.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Controllers
{
    public class UtilityController : Controller
    {
        public UtilityController()
        {

        }
        [HttpGet]
        [Route("[controller]/{imageFile}")]
        public IActionResult get([FromRoute] String imageFile)
        {
            try
            {
                return File(FileService.loadImg(imageFile), "image/jpeg");
            }
            catch (FileNotFoundException)
            {
                return NotFound();
            }
        }
    }
}
