using GSL.Domain.Entidades;
using GSL.Infra.Data.Context;
using GSL.Infra.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GSL.Infra.Data.Repository
{
    public class TelefoneRepository : Repository<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(GSLContext context) : base(context)
        {

        }

      
    }
}
