using GSL.Domain.Entidades;

namespace GSL.Infra.Data.Repository.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        void CreateUser(string username, string password, string role, Guid pessoaId);
        Task<Usuario> ValidateUser(string username, string password);

    }
}
