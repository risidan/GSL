using GSL.Application.ViewModel;

namespace GSL.Application.Services.Interfaces
{
    public interface IClientesService
    {
        Task<ClienteVM> GetById(Guid idCliente);
        Task<List<ClienteVM>> GetAll();
        Task<Guid> Create (ClienteVM clienteVM);
    }
}