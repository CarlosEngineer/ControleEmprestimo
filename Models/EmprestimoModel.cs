using System.ComponentModel.DataAnnotations;

namespace ControleEmprestimo.Models
{
    public class EmprestimoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "obrigatorio.")]
        public string? Recebedor { get; set; }

        [Required(ErrorMessage = "obrigatorio.")]
        public string? Fornecedor { get; set; }

        [Required(ErrorMessage = "obrigatorio.")]
        public string? LivroEmprestado { get; set; }
        public DateTime DataEmprestimo { get; set; } = DateTime.Now;

    }
}
