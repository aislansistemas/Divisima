using System.Collections.Generic;
using divisima.Models;
using Microsoft.AspNetCore.Identity;

namespace Divisima.Models
{
    public class Usuario: IdentityUser
    {
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public virtual List<Produto> Produtos { get; set;}
    }
}