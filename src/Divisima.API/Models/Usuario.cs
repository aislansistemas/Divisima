using System.Collections.Generic;
using divisima.Models;
using Divisima.Enums.PerfilUsuarioEnums;
using Microsoft.AspNetCore.Identity;

namespace Divisima.Models
{
    public class Usuario: IdentityUser
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public string Foto { get; set; }
        public string PerfilUsuario { get; set; }
        public virtual List<Produto> Produtos { get; set; }
        public virtual List<Pedido> Pedidos { get; set; }
    }
}