using GSL.Application.ViewModel;

namespace GSL.Application.Services.Interfaces
{
    public interface IUsuariosService
    {
        Task<AuthenticateVM> Authenticate(UsuarioVM usuario);

    }
}
