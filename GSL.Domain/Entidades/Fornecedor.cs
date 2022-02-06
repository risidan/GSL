namespace GSL.Domain.Entidades
{
    public class Fornecedor: Pessoa
    {
        public Fornecedor()
        {
            SetPJ();
        }
        public string RazaoSocial { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoEstadual { get; set; }
        public string NomeContato { get; set; }

    }
}
