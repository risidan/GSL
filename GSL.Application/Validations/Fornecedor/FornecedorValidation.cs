using FluentValidation;
using GSL.Application.ViewModel;

namespace GSL.Application.Validations.Fornecedor
{
    public class FornecedorValidation : AbstractValidator<FornecedorVM> 
    {
        public FornecedorValidation()
        {
            ValidarNome();
        }

        protected void ValidarNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome é obrigatório")
                .Length(2, 150).WithMessage("Nome deve ter entre 2 e 150 caracteres");
        }

    }
}
