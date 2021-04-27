using System;
using System.IO;
using Divisima.Services.Exceptions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace divisima.Services
{
    public class UploadFile : IUploadFile
    {   
        private readonly IWebHostEnvironment _hostingEnvironment;

        public UploadFile(IWebHostEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
        }

        public string Upload(IFormFile formFile, string directory)
        {
            try{
                var nomeArquivo = formFile.FileName;
                var novoNomeArquivo = nomeArquivo.Replace(" ", "_");
                string pastaArquivos = Path.Combine(_hostingEnvironment.WebRootPath, directory);
                string caminhoArquivo = Path.Combine(pastaArquivos, novoNomeArquivo);
                using (var fileStream = new FileStream(caminhoArquivo, FileMode.Create))
                {
                    formFile.CopyTo(fileStream);
                }
                return novoNomeArquivo;
            } catch(Exception) {
                throw new InvalidArgumentException("Não foi possível salvar o arquivo.");
            }    
        }
    }
}