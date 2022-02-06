using AutoMapper;
using GSL.Application.Services;
using GSL.Application.ViewModel;
using GSL.Infra.Data.Interfaces;
using GSL.Infra.Data.Repository.Interfaces;
using Moq;
using System;
using Xunit;

namespace GSL.Tests.Application.Cliente
{
    public class CreateTest
    {
        private readonly IClienteRepository _repository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly Mock<IUnitOfWork> _uow;

        public CreateTest(IClienteRepository repository, IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _repository = repository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _uow = new Mock<IUnitOfWork>();
        }

        [Fact]
        public async void Task_Add_ValidData_Return_OkResult()
        {
            //Arrange  
            _uow.Setup(s => s.Commit()).ReturnsAsync(true);
            var service = new ClientesService(_repository, _usuarioRepository, _mapper, _uow.Object);
            var cliente = new ClienteVM() {
                Nome = "Daniel Risi",
                CpfCnpj = "48452078900",
                Email = "daniel.risi@gmail.com",
                Senha = "123456",
                RG = "487511448",
                DataNascimento = "09/09/1996"
            };

            //Act  
            var data = await service.Create(cliente);

            //Assert  
            Assert.IsType<Guid>(data);
        }

        [Fact]
        public async void Task_Add_InvalidData_Return_BadRequest()
        {
            _uow.Setup(s => s.Commit()).ReturnsAsync(true);
            var service = new ClientesService(_repository, _usuarioRepository, _mapper, _uow.Object);
            var cliente = new ClienteVM()
            {
                CpfCnpj = "48452078900",
                Email = "daniel.risi@gmail.com",
                Senha = "123456",
                RG = "487511448",
                DataNascimento = "09/09/1996"
            };

            //Assert  
            await Assert.ThrowsAsync<ApplicationException>(() => service.Create(cliente));
        }


    }
}
