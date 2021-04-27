using Microsoft.AspNetCore.Http;

namespace divisima.Services
{
    public interface IUploadFile
    {
         string Upload(IFormFile formFile, string directory);
    }
}