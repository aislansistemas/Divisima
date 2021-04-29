using System.ComponentModel.DataAnnotations;
using divisima.Models;
using Divisima.Enums;

namespace Divisima.Models
{
    public class FotoProduto
    {
        [Key]
        public long FotoId { get; set; }
        public string Foto { get; set; }
        public BooleanoEnum IsFotoPrincipal { get; set; }
        public long ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
    }
}