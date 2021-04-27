using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Divisima.Enums;
using Divisima.Enums.PagamentoEnums;

namespace Divisima.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        public string UsuarioId { get; set; }

        [Required(ErrorMessage="O cep deve ser preenchido!")]
        public string Cep { get; set; }

        [Required(ErrorMessage="A cidade deve ser preenchida!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage="O estado deve ser preenchido!")]
        public string Estado { get; set; }

        [Required(ErrorMessage="O bairro deve ser preenchido!")]
        public string Bairro { get; set; }
        
        [Required(ErrorMessage="O nome da rua ou avenida deve ser preenchido!")]
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public decimal ValorTotal { get; set; }
        public PagamentoStatusEnum Status { get; set; }
        public BooleanoEnum Entregue { get; set; }
        public DateTime Data { get; set; }
        public virtual List<PedidoItem> PedidoItem { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}