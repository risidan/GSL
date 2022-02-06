
using FluentValidation.Results;

namespace GSL.Application.ViewModel
{
    public abstract class EntidadeBaseVM
    {

        public Guid Id { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
        public bool Ativo { get; private set; }

        public ValidationResult? ValidationResult {get; protected set;}

        public virtual bool IsValid()
        {
            return ValidationResult.IsValid;
        }
    }
}
