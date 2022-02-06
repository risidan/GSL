using AutoMapper;
using GSL.Application.Services.Interfaces;
using GSL.Application.ViewModel;
using GSL.Domain.Entidades;
using GSL.Infra.Data.Interfaces;
using GSL.Infra.Data.Repository.Interfaces;

namespace GSL.Application.Services
{
    public class ColaboradoresService : IColaboradoresService
    {
        private readonly IColaboradorRepository _repository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public ColaboradoresService(IColaboradorRepository repository, IUsuarioRepository usuarioRepository, IMapper mapper, IUnitOfWork uow)
        {
            _repository = repository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _uow = uow;
        }
        public async Task<Guid> Create(ColaboradorVM colaboradorVM)
        {
            if (!colaboradorVM.IsValid())
                throw new ApplicationException(colaboradorVM.ValidationResult.Errors.ToString());

            var colaborador = _mapper.Map<Colaborador>(colaboradorVM);
            colaborador = _repository.Add(colaborador);
            if (await _uow.Commit())
            {
                _usuarioRepository.CreateUser(colaborador.CpfCnpj, colaboradorVM.Senha, colaborador.GetType().Name.ToString(), colaborador.Id);
                await _uow.Commit();
            }
            return colaborador.Id;
        }

        public async Task<List<ColaboradorVM>> GetAll()
        {
            var colaboradores = await _repository.GetAll();
            return _mapper.Map<List<ColaboradorVM>>(colaboradores);
        }

        public async Task<ColaboradorVM> GetById(Guid idColaborador)
        {
            var colaborador = await _repository.GetById(idColaborador);
            return _mapper.Map<ColaboradorVM>(colaborador);
        }
    }
}
