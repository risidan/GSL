using AutoMapper;
using GSL.Application.ViewModel;
using GSL.Domain.Entidades;

namespace GSL.Application.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Cliente, ClienteVM>();
            CreateMap<Fornecedor, FornecedorVM>();
            CreateMap<Colaborador, ColaboradorVM>();
        }
    }
}
