using FluentValidation.Results;
using GSL.Application.Validations.Cliente;

namespace GSL.Application.ViewModel
{
    public class ClienteVM: PessoaVM
    {
        public string RG { get; set; }
        public string DataNascimento { get; set; }

        public bool IsValid()
        {
            ValidationResult = new ClienteValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
