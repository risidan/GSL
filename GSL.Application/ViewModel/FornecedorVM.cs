using GSL.Application.Validations.Fornecedor;

namespace GSL.Application.ViewModel
{
    public class FornecedorVM : PessoaVM
    {
        public string RazaoSocial { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoEstadual { get; set; }
        public string NomeContato { get; set; }

        public bool IsValid()
        {
            ValidationResult = new FornecedorValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
