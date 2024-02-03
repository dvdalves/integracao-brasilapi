using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenericoDTO<Endereco>> BuscarEnderecoPorCep(string cep);
        Task<ResponseGenericoDTO<List<Banco>>> BuscarTodosBancos();
        Task<ResponseGenericoDTO<Banco>> BuscarBancoPorCodigo(string codigo);
    }
}