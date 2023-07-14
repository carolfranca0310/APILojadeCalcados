using Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace API.LojaDeCalcados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private IProdutoService _service;

        public ProdutosController(IProdutoService service)
        {
            _service = service;
        }

        [HttpPost("CriarProduto")]
        public async Task<IActionResult> CriarProduto([FromBody] Produto produto)
        {
            Produto novoProduto = await _service.CriarNovoProduto(produto);

            return Ok(novoProduto);
        } 
    }
}
