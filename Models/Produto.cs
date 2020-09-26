using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace divisima.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        [Required(ErrorMessage="Nome deve ser preenchido*")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Required(ErrorMessage="Valor deve ser preenchido*")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage="Quantidade deve ser preenchido*")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage="Tamanho deve ser preenchido*")]
        public int Tamanho { get; set; }
        public string Foto { get; set; }
    }
}