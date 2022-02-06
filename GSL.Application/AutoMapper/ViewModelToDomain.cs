using AutoMapper;
using GSL.Application.ViewModel;
using GSL.Domain.Entidades;

namespace GSL.Application.AutoMapper
{

    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<ClienteVM, Cliente>()
                .ForMember(f => f.TipoPessoa, i => i.Ignore());
            CreateMap<FornecedorVM, Fornecedor>()
                .ForMember(f => f.TipoPessoa, i => i.Ignore());
            CreateMap<ColaboradorVM, Colaborador>()
                .ForMember(f => f.TipoPessoa, i => i.Ignore());
        }
    }
}
