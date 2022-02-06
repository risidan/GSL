namespace GSL.Application.ViewModel
{
    public class TelefoneVM : EntidadeBaseVM
    {
        public Guid PessoaId { get; set; }
        public string Ddi { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public bool TelefonePrincipal { get; set; }
    }
}
