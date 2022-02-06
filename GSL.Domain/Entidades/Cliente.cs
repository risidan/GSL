namespace GSL.Domain.Entidades
{
    public class Cliente: Pessoa
    {
        public Cliente()
        {
            SetPF();
        }
        public string RG { get; set; }
        public string DataNascimento { get; set; }
    }
}
