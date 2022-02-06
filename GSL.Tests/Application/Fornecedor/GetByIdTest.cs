using AutoMapper;
using GSL.Application.Services;
using GSL.Application.ViewModel;
using GSL.Infra.Data.Interfaces;
using GSL.Infra.Data.Repository.Interfaces;
using System;
using Xunit;

namespace GSL.Tests.Application.Fornecedor
{
    public class GetByIdTest
    {
        private readonly IFornecedorRepository _repository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public GetByIdTest(IFornecedorRepository repository, IUsuarioRepository usuarioRepository, IMapper mapper, IUnitOfWork uow)
        {
            _repository = repository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _uow = uow;
        }

        [Fact]
        public async void Task_GetFornecedorById_Return_FornecedorVM()
        {
            //Arrange  
            var service = new FornecedoresService(_repository, _usuarioRepository, _mapper, _uow);
            var FornecedorId = new Guid("08d9e9c2-dc00-4414-8bfe-5e5de65e9a40");

            //Act  
            var data = await service.GetById(FornecedorId);

            //Assert  
            Assert.IsType<FornecedorVM>(data);
        }


        [Fact]
        public async void Task_GetPostById_Return_Null()
        {
            //Arrange  
            var service = new FornecedoresService(_repository, _usuarioRepository, _mapper, _uow);
            var FornecedorId = new Guid();

            //Act  
            var data = await service.GetById(FornecedorId);

            //Assert  
            Assert.Null(data);
        }


        [Fact]
        public async void Task_GetPostById_MatchResult()
        {
            //Arrange  
            var service = new FornecedoresService(_repository, _usuarioRepository, _mapper, _uow);
            var FornecedorId = new Guid("08d9e9c2-dc00-4414-8bfe-5e5de65e9a40");

            //Act  
            var data = await service.GetById(FornecedorId);

            //Assert  
            Assert.IsType<FornecedorVM>(data);

            Assert.Equal("Risitec", data.Nome);
            Assert.Equal("48452078000190", data.CpfCnpj);
        }


    }
}
