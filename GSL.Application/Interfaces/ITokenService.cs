using GSL.Domain.Entidades;

namespace GSL.Application.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(Usuario usuario);
    }
}
