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
            var path = Environment.CurrentDirectory;
            var imagePath = Path.Combine(path, "image", imageFile);
            var img = System.IO.File.OpenRead(imagePath);
            return File(img, "image/jpeg");    
        }
    }
}
