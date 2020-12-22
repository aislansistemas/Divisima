using System.ComponentModel.DataAnnotations;
using divisima.Models;
using Divisima.Enums;

namespace Divisima.Models
{
    public class FotoProduto
    {
        [Key]
        public int FotoId { get; set; }
        public string Foto { get; set; }
        public BooleanoEnum IsFotoPrincipal { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
    }
}