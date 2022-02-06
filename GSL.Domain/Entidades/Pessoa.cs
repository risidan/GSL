namespace GSL.Domain.Entidades
{
    public class Pessoa : EntidadeBase
    {
        private const string _pessoaFisica = "PF";
        private const string _pessoaJuridica = "PJ";

        public string Nome { get; set; }
        public string TipoPessoa { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual List<Endereco> Enderecos { get; set; }
        public virtual List<Telefone> Telefones { get; set; }

        protected void SetPF()
        {
            TipoPessoa = _pessoaFisica;
        }

        protected void SetPJ()
        {
            TipoPessoa = _pessoaJuridica;
        }
    }
}
