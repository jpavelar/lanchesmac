using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = " O nome a categoria é obrigatório")]
        [StringLength(30, ErrorMessage = " O tamanho máximo de caracteres é {1}")]
        [Display(Name ="Nome")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = " A descrição da categoria é obrigatória")]
        [StringLength(200, ErrorMessage = " O tamanho máximo de caracteres é {1}")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
