using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Configurations
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Endereco, EnderecoResponseDTO>().ReverseMap();
            CreateMap<ResponseGenericoDTO<Endereco>, ResponseGenericoDTO<EnderecoResponseDTO>>().ReverseMap();
            CreateMap<ResponseGenericoDTO<EnderecoResponseDTO>, ResponseGenericoDTO<Endereco>>().ReverseMap();
        }
    }
}