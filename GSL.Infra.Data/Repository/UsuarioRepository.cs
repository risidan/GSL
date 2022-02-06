using GSL.Domain.Entidades;
using GSL.Infra.Data.Context;
using GSL.Infra.Data.Repository.Interfaces;
using GSL.Infra.Helper.Helpers;

namespace GSL.Infra.Data.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(GSLContext context) : base(context)
        {

        }

        public void CreateUser(string username, string password, string role, Guid pessoaId)
        {

            var usuario = new Usuario()
            {
                Username = username,
                Password = password.HashPassword(),
                Role = role.ToLower(),
            };

            switch (role)
            {
                case nameof(Cliente):
                    usuario.ClienteId = pessoaId;
                    break;
                case nameof(Fornecedor):
                    usuario.FornecedorId = pessoaId;
                    break;
                case nameof(Colaborador):
                    usuario.ColaboradorId = pessoaId;
                    break;

            }
            Add(usuario);
        }

        public async Task<Usuario> ValidateUser(string username, string password)
        {

            return await Find(wh => wh.Username == username && wh.Password == password.HashPassword());
        }
    }
}
