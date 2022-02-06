using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSL.Domain.Entidades
{
    public class Telefone : EntidadeBase
    {
        public Guid? ClienteId { get; set; }
        public Guid? FornecedorId { get; set; }
        public Guid? ColaboradorId { get; set; }
        public string Ddi { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public bool TelefonePrincipal { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Colaborador Colaborador { get; set; }
    }
}
