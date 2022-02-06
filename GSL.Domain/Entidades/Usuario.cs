namespace GSL.Domain.Entidades
{
    public class Usuario : EntidadeBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Guid? ClienteId { get; set; }
        public Guid? FornecedorId { get; set; }
        public Guid? ColaboradorId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Colaborador Colaborador { get; set; }
    }
}
