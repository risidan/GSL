using GSL.Application.ViewModel;

namespace GSL.Application.Services.Interfaces
{
    public interface IFornecedoresService
    {
        Task<FornecedorVM> GetById(Guid idFornecedor);
        Task<List<FornecedorVM>> GetAll();
        Task<Guid> Create(FornecedorVM fornecedorVM);
    }
}