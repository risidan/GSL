using AutoMapper;
using GSL.Application.Services.Interfaces;
using GSL.Application.ViewModel;
using GSL.Domain.Entidades;
using GSL.Infra.Data.Interfaces;
using GSL.Infra.Data.Repository.Interfaces;

namespace GSL.Application.Services
{
    public class ClientesService : IClientesService
    {
        private readonly IClienteRepository _repository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;


        public ClientesService(IClienteRepository repository, IUsuarioRepository usuarioRepository, IMapper mapper, IUnitOfWork uow)
        {
            _repository = repository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<Guid> Create(ClienteVM clienteVM)
        {
            if (!clienteVM.IsValid())
                throw new ApplicationException(clienteVM.ValidationResult.Errors.ToString());


            var cliente = _mapper.Map<Cliente>(clienteVM);
            cliente = _repository.Add(cliente);

            if (await _uow.Commit())
            {
                _usuarioRepository.CreateUser(cliente.CpfCnpj, clienteVM.Senha, cliente.GetType().Name.ToString(), cliente.Id);
                await _uow.Commit();
            }

            return cliente.Id;
        }

        public async Task<List<ClienteVM>> GetAll()
        {
            var clientes = await _repository.GetAll();
            return _mapper.Map<List<ClienteVM>>(clientes);
        }

        public async Task<ClienteVM> GetById(Guid idCliente)
        {
            var cliente = await _repository.GetById(idCliente);
            return _mapper.Map<ClienteVM>(cliente);
        }
    }
}
