using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Divisima.Enums;
using Divisima.Enums.GeneroEnum;

namespace divisima.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        [Required(ErrorMessage = "Nome deve ser preenchido*")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Valor deve ser preenchido*")]
        [DisplayFormat(DataFormatString = "{0:f2}")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "Quantidade deve ser preenchido*")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "Tamanho deve ser preenchido*")]
        public int Tamanho { get; set; }
        public string Foto { get; set; }
        public DateTime DataCadastro { get; set; }
        [Required(ErrorMessage = "Gênero deve ser preenchido*")]
        public GeneroEnum Genero { get; set; }
    }
}