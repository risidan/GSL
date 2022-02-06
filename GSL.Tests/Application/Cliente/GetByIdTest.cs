using AutoMapper;
using GSL.Application.Services;
using GSL.Application.ViewModel;
using GSL.Infra.Data.Interfaces;
using GSL.Infra.Data.Repository.Interfaces;
using System;
using Xunit;

namespace GSL.Tests.Application.Cliente
{
    public class GetByIdTest
    {
        private readonly IClienteRepository _repository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public GetByIdTest(IClienteRepository repository, IUsuarioRepository usuarioRepository, IMapper mapper, IUnitOfWork uow)
        {
            _repository = repository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _uow = uow;
        }

        [Fact]
        public async void Task_GetClienteById_Return_ClienteVM()
        {
            //Arrange  
            var service = new ClientesService(_repository, _usuarioRepository, _mapper, _uow);
            var clienteId = new Guid("08d9e91e-2661-4793-885c-15fd06cf69b0");

            //Act  
            var data = await service.GetById(clienteId);

            //Assert  
            Assert.IsType<ClienteVM>(data);
        }


        [Fact]
        public async void Task_GetPostById_Return_Null()
        {
            //Arrange  
            var service = new ClientesService(_repository, _usuarioRepository, _mapper, _uow);
            var clienteId = new Guid();

            //Act  
            var data = await service.GetById(clienteId);

            //Assert  
            Assert.Null(data);
        }


        [Fact]
        public async void Task_GetPostById_MatchResult()
        {
            //Arrange  
            var service = new ClientesService(_repository, _usuarioRepository, _mapper, _uow);
            var clienteId = new Guid("08d9e91e-2661-4793-885c-15fd06cf69b0");

            //Act  
            var data = await service.GetById(clienteId);

            //Assert  
            Assert.IsType<ClienteVM>(data);

            Assert.Equal("Daniel Risi", data.Nome);
            Assert.Equal("48452078900", data.CpfCnpj);
        }


    }
}
