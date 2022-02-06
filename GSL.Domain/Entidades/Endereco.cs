using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSL.Domain.Entidades
{
    public class Endereco : EntidadeBase
    {
        public Guid? ClienteId { get; set; }
        public Guid? FornecedorId { get; set; }
        public Guid? ColaboradorId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public bool EnderecoPrincipal { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Colaborador Colaborador { get; set; }
    }
}
