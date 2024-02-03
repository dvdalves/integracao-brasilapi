using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenericoDTO<List<Banco>>> BuscarTodosBancos();
        Task<ResponseGenericoDTO<Banco>> BuscarBancoPorCodigo(string codigo);
    }
}
