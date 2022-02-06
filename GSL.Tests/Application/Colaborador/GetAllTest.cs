using AutoMapper;
using GSL.Application.Services;
using GSL.Application.ViewModel;
using GSL.Infra.Data.Interfaces;
using GSL.Infra.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using Xunit;

namespace GSL.Tests.Application.Colaborador
{
    public class GetAllTest
    {
        private readonly IColaboradorRepository _repository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public GetAllTest(IColaboradorRepository repository, IUsuarioRepository usuarioRepository, IMapper mapper, IUnitOfWork uow)
        {
            _repository = repository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _uow = uow;
        }

        [Fact]
        public async void Task_GetColaboradors_Return_All()
        {
            //Arrange  
            var service = new ColaboradoresService(_repository, _usuarioRepository, _mapper, _uow);

            //Act  
            var data = await service.GetAll();

            //Assert  
            Assert.IsType<List<ColaboradorVM>>(data);
        }

    }
}
