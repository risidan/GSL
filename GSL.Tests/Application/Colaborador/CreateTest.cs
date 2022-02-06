using AutoMapper;
using GSL.Application.Services;
using GSL.Application.ViewModel;
using GSL.Infra.Data.Interfaces;
using GSL.Infra.Data.Repository.Interfaces;
using Moq;
using System;
using Xunit;

namespace GSL.Tests.Application.Colaborador
{
    public class CreateTest
    {
        private readonly IColaboradorRepository _repository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly Mock<IUnitOfWork> _uow;

        public CreateTest(IColaboradorRepository repository, IUsuarioRepository usuarioRepository, IMapper mapper)
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
            var service = new ColaboradoresService(_repository, _usuarioRepository, _mapper, _uow.Object);
            var Colaborador = new ColaboradorVM() {
                Nome = "Daniel Risi",
                CpfCnpj = "48452078910",
                Email = "daniel.risi@gmail.com",
                Senha = "123456",
                Matricula = "123",
                Cargo = "Teste",
                Setor = "Administrativo",
                NumeroCtps = "123456",
                DataNascimento = Convert.ToDateTime("09/09/1996"),
                DataAdmissao = Convert.ToDateTime("09/09/1996"),
                DataDemissao = Convert.ToDateTime("10/10/2050"),
            };

            //Act  
            var data = await service.Create(Colaborador);

            //Assert  
            Assert.IsType<Guid>(data);
        }

        [Fact]
        public async void Task_Add_InvalidData_Return_BadRequest()
        {
            _uow.Setup(s => s.Commit()).ReturnsAsync(true);
            var service = new ColaboradoresService(_repository, _usuarioRepository, _mapper, _uow.Object);
            var Colaborador = new ColaboradorVM()
            {
                CpfCnpj = "48452078910",
                Email = "daniel.risi@gmail.com",
                Senha = "123456",
                Matricula = "123",
                Cargo = "Teste",
                Setor = "Administrativo",
                NumeroCtps = "123456",
                DataNascimento = Convert.ToDateTime("09/09/1996"),
                DataAdmissao = Convert.ToDateTime("09/09/1996"),
                DataDemissao = Convert.ToDateTime("10/10/2050"),
            };

            //Assert  
            await Assert.ThrowsAsync<ApplicationException>(() => service.Create(Colaborador));
        }


    }
}
