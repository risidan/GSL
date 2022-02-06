using FluentValidation;
using GSL.Application.ViewModel;

namespace GSL.Application.Validations.Cliente
{
    public class ClienteValidation : AbstractValidator<ClienteVM> 
    {
        public ClienteValidation()
        {
            ValidarNome();
            ValidarCpfCnpj();
            ValidarEmail();
            ValidarSenha();
            ValidarDataNascimento();
        }

        protected void ValidarNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome é obrigatório")
                .Length(2, 150).WithMessage("Nome deve ter entre 2 e 150 caracteres");
        }

        protected void ValidarCpfCnpj()
        {
            RuleFor(c => c.CpfCnpj)
                .NotEmpty().WithMessage("Cpf é obrigatório");
        }

        protected void ValidarEmail()
        {
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email é obrigatório");
        }

        protected void ValidarSenha()
        {
            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Senha é obrigatório");
        }

        protected void ValidarRg()
        {
            RuleFor(c => c.RG)
                .NotEmpty().WithMessage("RG é obrigatório");
        }

        protected void ValidarDataNascimento()
        {
            RuleFor(c => c.DataNascimento)
                .NotEmpty().WithMessage("Data de nascimento é obrigatório");
        }
    }
}
