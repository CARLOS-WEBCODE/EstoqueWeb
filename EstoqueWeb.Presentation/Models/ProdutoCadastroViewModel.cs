using System.ComponentModel.DataAnnotations;

namespace EstoqueWeb.Presentation.Models
{
    public class ProdutoCadastroViewModel
    {
        [MinLength(3, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o preço.")]
        public string? Preco { get; set; }

        [Required(ErrorMessage = "Por favor, informe a quantidade.")]
        public string? Quantidade { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de validade.")]
        public string? Data { get; set; }

        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(500, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a descrição do produto.")]
        public string? Descricao { get; set; }
    }
}
