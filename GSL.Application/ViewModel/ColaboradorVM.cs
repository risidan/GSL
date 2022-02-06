using GSL.Application.Validations.Colaborador;

namespace GSL.Application.ViewModel
{
    public class ColaboradorVM : PessoaVM
    {
        public string Matricula { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public string NumeroCtps { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDemissao { get; set; }

        public bool IsValid()
        {
            ValidationResult = new ColaboradorValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
