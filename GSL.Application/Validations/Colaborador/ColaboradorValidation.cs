using FluentValidation;
using GSL.Application.ViewModel;

namespace GSL.Application.Validations.Colaborador
{
    public class ColaboradorValidation : AbstractValidator<ColaboradorVM> 
    {
        public ColaboradorValidation()
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
