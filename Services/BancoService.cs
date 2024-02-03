using AutoMapper;
using IntegracaoBrasilApi.DTOs;
using IntegracaoBrasilApi.Interfaces;
using IntegracaoBrasilApi.Models;

namespace IntegracaoBrasilApi.Services
{
    public class BancoService : IBancoService
    {
        private readonly IBrasilApi _brasilApi;
        private readonly IMapper _mapper;

        public BancoService(IBrasilApi brasilApi, IMapper mapper)
        {
            _brasilApi = brasilApi;
            _mapper = mapper;
        }

        public async Task<ResponseGenericoDTO<Banco>> BuscarBancoPorCodigo(string codigo)
        {
            var result = await _brasilApi.BuscarBancoPorCodigo(codigo);
            return _mapper.Map<ResponseGenericoDTO<Banco>>(result);
        }

        public async Task<ResponseGenericoDTO<List<Banco>>> BuscarTodosBancos()
        {
            var result = await _brasilApi.BuscarTodosBancos();
            return _mapper.Map<ResponseGenericoDTO<List<Banco>>>(result);
        }
    }
}
