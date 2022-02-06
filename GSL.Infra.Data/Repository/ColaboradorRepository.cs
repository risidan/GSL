using GSL.Domain.Entidades;
using GSL.Infra.Data.Context;
using GSL.Infra.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GSL.Infra.Data.Repository
{
    public class ColaboradorRepository : Repository<Colaborador>, IColaboradorRepository
    {
        public ColaboradorRepository(GSLContext context) : base(context)
        {

        }

      
    }
}
