using Application.Dtos;
using AutoMapper;
using Domain;

namespace Application.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Revenda, RevendaDto>().ReverseMap();
            CreateMap<Endereco, EnderecoDto>().ReverseMap();
            CreateMap<Contato, ContatoDto>().ReverseMap();
            CreateMap<Telefone, TelefoneDto>().ReverseMap();
            CreateMap<Ordem, OrdemDto>().ReverseMap();
            CreateMap<Produto, ProdutoDto>().ReverseMap();
        }

    }
}
