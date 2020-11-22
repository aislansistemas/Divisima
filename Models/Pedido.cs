using System;
using System.Collections.Generic;
using Divisima.Enums.PagamentoEnums;

namespace Divisima.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string UsuarioId { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public decimal ValorTotal { get; set; }
        public PagamentoStatusEnum Status { get; set; }
        public DateTime Data { get; set; }
        public List<PedidoItem> PedidoItem { get; set; }
    }
}