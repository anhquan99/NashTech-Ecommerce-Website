using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerece_Web.Services
{
    public class FileService
    {
        static String path = Path.Combine(Environment.CurrentDirectory, "image");
        public static FileStream loadImg(String imageFile)
        {
            String imagePath = Path.Combine(path, imageFile);
            try
            {
                return System.IO.File.OpenRead(imagePath);
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }
        public Boolean uploadFile(IFormFile file)
        {
            try
            {
                // if folder not exist
                FileInfo folder = new FileInfo(path);
                folder.Directory.Create();

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }
        public Boolean uploadMultiFile(IEnumerable<IFormFile> files)
        {
            try
            {
                // if folder not exist
                FileInfo folder = new FileInfo(path);
                folder.Directory.Create();

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    foreach (var i in files)
                    {
                        i.CopyTo(stream);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }
        public Boolean deleteFile(String file)
        {
            try
            {
                // if folder not exist
                FileInfo folder = new FileInfo(path);
                folder.Directory.Create();

                if (File.Exists(Path.Combine(path, file)))
                {
                    File.Delete(Path.Combine(path, file));
                }
                else
                {
                    throw new FileNotFoundException();
                }
                return true;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FILE NOT FOUND");
                return false;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }
    }
}

