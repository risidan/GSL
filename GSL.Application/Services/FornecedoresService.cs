using AutoMapper;
using GSL.Application.Services.Interfaces;
using GSL.Application.ViewModel;
using GSL.Domain.Entidades;
using GSL.Infra.Data.Interfaces;
using GSL.Infra.Data.Repository.Interfaces;

namespace GSL.Application.Services
{
    public class FornecedoresService : IFornecedoresService
    {
        private readonly IFornecedorRepository _repository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public FornecedoresService(IFornecedorRepository repository, IUsuarioRepository usuarioRepository, IMapper mapper, IUnitOfWork uow)
        {
            _repository = repository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _uow = uow;
        }
        public async Task<Guid> Create(FornecedorVM fornecedorVM)
        {
            if (!fornecedorVM.IsValid())
                throw new ApplicationException(fornecedorVM.ValidationResult.Errors.ToString());

            var fornecedor = _mapper.Map<Fornecedor>(fornecedorVM);
            fornecedor = _repository.Add(fornecedor);
            if (await _uow.Commit())
            {
                _usuarioRepository.CreateUser(fornecedor.CpfCnpj, fornecedorVM.Senha, fornecedor.GetType().Name.ToString(), fornecedor.Id);
                await _uow.Commit();
            }
            return fornecedor.Id;
        }

        public async Task<List<FornecedorVM>> GetAll()
        {
            var fornecedores = await _repository.GetAll();
            return _mapper.Map<List<FornecedorVM>>(fornecedores);
        }

        public async Task<FornecedorVM> GetById(Guid idFornecedor)
        {
            var fornecedor = await _repository.GetById(idFornecedor);
            return _mapper.Map<FornecedorVM>(fornecedor);
        }
    }
}
