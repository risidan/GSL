using GSL.Application.Services.Interfaces;
using GSL.Application.ViewModel;
using GSL.Infra.Data.Repository.Interfaces;

namespace GSL.Application.Services
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IUsuarioRepository _repository;
        private readonly ITokenService _tokenService;


        public UsuariosService(IUsuarioRepository repository, ITokenService tokenService)
        {
            _repository = repository;
            _tokenService = tokenService;
        }

        public async Task<AuthenticateVM> Authenticate(UsuarioVM usuario)
        {
            var _usuario = await _repository.ValidateUser(usuario.Usuario, usuario.Senha);

            if (usuario == null)
                throw new ApplicationException("Usuario e/ou senha inválido!");

            var token = _tokenService.GenerateToken(_usuario);
            return new AuthenticateVM()
            {
                AccessToken = token
            };
        }
    }
}
