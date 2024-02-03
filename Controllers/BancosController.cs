using IntegracaoBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoBrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancosController : ControllerBase
    {
        private readonly IBancoService _bancoService;

        public BancosController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodosBancos()
        {
            var result = await _bancoService.BuscarTodosBancos();
            return Ok(result);
        }

        [HttpGet("{codigo}")]
        public async Task<IActionResult> BuscarBancoPorCodigo(string codigo)
        {
            var result = await _bancoService.BuscarBancoPorCodigo(codigo);
            return Ok(result);
        }
    }
}