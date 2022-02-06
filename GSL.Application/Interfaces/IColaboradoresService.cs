using GSL.Application.ViewModel;

namespace GSL.Application.Services.Interfaces
{
    public interface IColaboradoresService
    {
        Task<ColaboradorVM> GetById(Guid idColaborador);
        Task<List<ColaboradorVM>> GetAll();
        Task<Guid> Create(ColaboradorVM colaboradorVM);
    }
}