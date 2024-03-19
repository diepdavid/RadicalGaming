using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using RadicalGaming.DataAccess.Repository.IRepository;

namespace RadicalGaming.DataAccess.Repository
{
    
    public class LocalFileUploadService : IFileUploadService
    {
        private readonly IWebHostEnvironment _webEnvironment;

        public LocalFileUploadService(IWebHostEnvironment webEnvironment)
        {
            _webEnvironment = webEnvironment;
        }

        public async Task<string> UploadFileAsync(IFormFile file, string fileName)
        {
            var filePath = Path.Combine(_webEnvironment.ContentRootPath, @"wwwroot\images\profile-picture", file.FileName);
            using var fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            return filePath;
        }
    }
}
