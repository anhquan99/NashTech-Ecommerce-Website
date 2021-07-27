using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerece_Web.Services
{
    public class FilesService
    {
        public static FileStreamResult loadImg(String imageFile)
        {
            var path = Environment.CurrentDirectory;
            var imagePath = Path.Combine(path, "image", imageFile);
            try
            {
                var img = System.IO.File.OpenRead(imagePath);
                return ControllerBase.File(img, "image/jpeg");
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }
    }
}
