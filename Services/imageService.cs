using Microsoft.AspNetCore.Routing.Constraints;
using static System.Net.Mime.MediaTypeNames;

namespace Ecommerce_MVC__11.Services
{
    public class imageService
    {
        private string _imageFolderPath;
        public imageService()
        {

            _imageFolderPath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Images");
        }
        public string UploadImage(IFormFile image)
        {
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
            var filePath = Path.Combine(_imageFolderPath, fileName);
            using (var stream = System.IO.File.Create(filePath))
            {
                image.CopyTo(stream);
            }
            return fileName;
        }

        public bool DeleteImage(string fileName)
        {
            var fullPath = Path.Combine(_imageFolderPath, fileName);
            if (File.Exists(fullPath))
            {
                File.Delete(fileName);
                return true;
            }
            return false;

        }
    }
}
