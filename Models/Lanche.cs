using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table(name:"Lanches")]
    public class Lanche
    {
        [Required]
        public int LancheId { get; set; }

        [Required(ErrorMessage="O nome do Lanche deverá ser informado")]
        [Display(Name ="Nome do Lanche")]
        [StringLength(200, ErrorMessage = "O nome deverá conter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do Lanche deverá ser informado")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(10, ErrorMessage = " A descrição deverá conter no mínimo {1} caracteres")]
        [MaxLength(50, ErrorMessage = " A descrição deverá conter no máximo {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do Lanche deverá ser informada")]
        [Display(Name = "Descrição detalhada")]
        [StringLength(200,ErrorMessage = "A descrição detalhada deverá conter no máximo {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "Informe um valor entre {1} e {2}")]
        public decimal Preco { get; set; }

        [Display(Name =" URL da Imagem")]
        [StringLength(200, ErrorMessage = "O caminho deverá conter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "URL da Imagem Thumbnail")]
        [StringLength(200, ErrorMessage = "O caminho deverá conter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Required(ErrorMessage = "Informar se o lanche é preferido ou não")]
        [Display(Name = "É preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Required(ErrorMessage = "Informar se o lanche possuí estoque")]
        [Display(Name = " Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
