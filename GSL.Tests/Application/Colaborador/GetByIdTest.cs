using AutoMapper;
using GSL.Application.Services;
using GSL.Application.ViewModel;
using GSL.Infra.Data.Interfaces;
using GSL.Infra.Data.Repository.Interfaces;
using System;
using Xunit;

namespace GSL.Tests.Application.Colaborador
{
    public class GetByIdTest
    {
        private readonly IColaboradorRepository _repository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public GetByIdTest(IColaboradorRepository repository, IUsuarioRepository usuarioRepository, IMapper mapper, IUnitOfWork uow)
        {
            _repository = repository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _uow = uow;
        }

        [Fact]
        public async void Task_GetColaboradorById_Return_ColaboradorVM()
        {
            //Arrange  
            var service = new ColaboradoresService(_repository, _usuarioRepository, _mapper, _uow);
            var ColaboradorId = new Guid("08d9e9c2-6c5b-4610-82f7-1ac26657ed58");

            //Act  
            var data = await service.GetById(ColaboradorId);

            //Assert  
            Assert.IsType<ColaboradorVM>(data);
        }


        [Fact]
        public async void Task_GetPostById_Return_Null()
        {
            //Arrange  
            var service = new ColaboradoresService(_repository, _usuarioRepository, _mapper, _uow);
            var ColaboradorId = new Guid();

            //Act  
            var data = await service.GetById(ColaboradorId);

            //Assert  
            Assert.Null(data);
        }


        [Fact]
        public async void Task_GetPostById_MatchResult()
        {
            //Arrange  
            var service = new ColaboradoresService(_repository, _usuarioRepository, _mapper, _uow);
            var ColaboradorId = new Guid("08d9e9c2-6c5b-4610-82f7-1ac26657ed58");

            //Act  
            var data = await service.GetById(ColaboradorId);

            //Assert  
            Assert.IsType<ColaboradorVM>(data);

            Assert.Equal("Daniel Risi", data.Nome);
            Assert.Equal("48452078910", data.CpfCnpj);
        }


    }
}
