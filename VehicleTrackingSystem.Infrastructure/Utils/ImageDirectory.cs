using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace VehicleTrackingSystem.Infrastructure.Utils
{
    public class ImageDirectory
    {

        public static string CheckDirectory(IHostEnvironment hostEnvironment, string path)
        {
            var hostingPath = hostEnvironment.ContentRootPath;
            var uploadPath = hostingPath + path;

            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }
            return uploadPath;
        }

        public static void RemoveExistingFile(IHostEnvironment hostEnvironment, string imageName, string imagePath)
        {
            var hostingPath = hostEnvironment.ContentRootPath;
            var uploadPath = hostingPath + imagePath + imageName;

            if (System.IO.File.Exists(uploadPath))
            {
                System.IO.File.Delete(uploadPath);
            }

        }

        public static async Task<bool> SaveImageInDirectory(byte[] imageInBytes, string path, string imagename)
        {
            try
            {
                using (var stream = new FileStream(string.Format(@"{0}{1}", path, imagename), FileMode.Create))
                {
                    await stream.WriteAsync(imageInBytes, 0, imageInBytes.Length);
                    await stream.FlushAsync();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }


    }
}
