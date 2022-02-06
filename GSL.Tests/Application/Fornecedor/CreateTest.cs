using AutoMapper;
using GSL.Application.Services;
using GSL.Application.ViewModel;
using GSL.Infra.Data.Interfaces;
using GSL.Infra.Data.Repository.Interfaces;
using Moq;
using System;
using Xunit;

namespace GSL.Tests.Application.Fornecedor
{
    public class CreateTest
    {
        private readonly IFornecedorRepository _repository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly Mock<IUnitOfWork> _uow;

        public CreateTest(IFornecedorRepository repository, IUsuarioRepository usuarioRepository, IMapper mapper)
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
            var service = new FornecedoresService(_repository, _usuarioRepository, _mapper, _uow.Object);
            var Fornecedor = new FornecedorVM() {
                Nome = "Risitec",
                CpfCnpj = "48452078000190",
                Email = "daniel.risi@gmail.com",
                Senha = "123456",
                RazaoSocial = "Risitec", 
                InscricaoMunicipal = "123456", 
                InscricaoEstadual = "654321", 
                NomeContato = "Daniel"
            };


            //Act  
            var data = await service.Create(Fornecedor);

            //Assert  
            Assert.IsType<Guid>(data);
        }

        [Fact]
        public async void Task_Add_InvalidData_Return_BadRequest()
        {
            _uow.Setup(s => s.Commit()).ReturnsAsync(true);
            var service = new FornecedoresService(_repository, _usuarioRepository, _mapper, _uow.Object);
            var Fornecedor = new FornecedorVM()
            {
                CpfCnpj = "48452078000190",
                Email = "daniel.risi@gmail.com",
                Senha = "123456",
                RazaoSocial = "Risitec",
                InscricaoMunicipal = "123456",
                InscricaoEstadual = "654321",
                NomeContato = "Daniel"
            };

            //Assert  
            await Assert.ThrowsAsync<ApplicationException>(() => service.Create(Fornecedor));
        }


    }
}
