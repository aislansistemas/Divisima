using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace divisima.Models
{
    public class Categoria
    {
        public long CategoriaId { get; set; }
        [Required(ErrorMessage="Nome deve ser preenchido*")]
        public string Nome { get; set; }
        public int Ativo { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}