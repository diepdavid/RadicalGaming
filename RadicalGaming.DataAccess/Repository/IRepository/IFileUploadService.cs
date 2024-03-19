using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RadicalGaming.DataAccess.Repository.IRepository
{
    public interface IFileUploadService
    {
        Task<string> UploadFileAsync(IFormFile file, string fileName);
    }
}
