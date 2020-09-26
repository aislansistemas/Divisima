using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace divisima.Services
{
    public class UploadFile: IUploadFile
    {   
        private readonly IHostingEnvironment _hostingEnvironment;

        public UploadFile(IHostingEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
        }
        public string Upload(IFormFile formFile){
            var nomeArquivo = formFile.FileName;
            var novoNomeArquivo = nomeArquivo.Replace(" ", "_");
            string pastaFotos = Path.Combine(_hostingEnvironment.WebRootPath, "arquivos");
            string caminhoArquivo = Path.Combine(pastaFotos, novoNomeArquivo);
            using (var fileStream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                formFile.CopyTo(fileStream);
            }
            return novoNomeArquivo;
        }
    }
}