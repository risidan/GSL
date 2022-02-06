using GSL.Domain.Entidades;
using GSL.Infra.Data.Context;
using GSL.Infra.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GSL.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(GSLContext context) : base(context)
        {

        }

      
    }
}
