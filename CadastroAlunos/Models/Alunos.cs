using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace CadastroAlunos.Models
{
    public class Alunos
    {
        public int AlunosId { get; set; }

        [DisplayName("Nome do Aluno")]
        [Required(ErrorMessage = "Informe seu nome.", AllowEmptyStrings = false)]
        [MinLength(4, ErrorMessage = "Por favor, informe seu nome.")]
        public string? NomeAluno { get; set; }

        [Required(ErrorMessage = "Informe seu dia de pagamento")]
        [DisplayName("Data de pagamento")]
        public string? DiaPgto { get; set; }

        [Range(16,99)]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Informe seu curso")]
        [MinLength(5, ErrorMessage = "Informe um curso válido.")]
        public string? Curso { get; set; }
        [Required(ErrorMessage = "Informe sua turma;")]
        public string? Turma { get; set; }
        public decimal ValorMensal { get; set; }

        [Required(ErrorMessage = "Informe seu telefone para nós possamos entrar em contato, se necessário.")]
        [DisplayName("Telefone")]
        [MinLength(13, ErrorMessage = "Informe um número de telefone válido.")]
        public string? TelefoneAluno { get; set; }

        [Required(ErrorMessage = "Informe seu E-mail.")]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        public string? EmailAluno { get; set;}
    }
}
