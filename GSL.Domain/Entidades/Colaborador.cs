namespace GSL.Domain.Entidades
{
    public class Colaborador: Pessoa
    {
        public Colaborador()
        {
            SetPF();
        }
        public string Matricula { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public string NumeroCtps { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDemissao { get; set; }
    }
}
