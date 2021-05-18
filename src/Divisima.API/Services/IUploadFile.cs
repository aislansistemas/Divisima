using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace divisima.Services
{
    public interface IUploadFile
    {
        string Upload(IFormFile formFile, string directory);
        Task DeleteFileAsync(string fileName, string directory);
    }
}