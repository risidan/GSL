namespace GSL.Application.ViewModel
{
    public class PessoaVM : EntidadeBaseVM
    {
        public string Nome { get; set; }
        public string? TipoPessoa { get; private set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<EnderecoVM>? Enderecos { get; private set; }
        public List<TelefoneVM>? Telefones { get; private set; }
    }
}
