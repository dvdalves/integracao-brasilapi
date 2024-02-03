using IntegracaoBrasilApi.DTOs;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenericoDTO<EnderecoResponseDTO>> BuscarEnderecoPorCep(string cep);
    }
}