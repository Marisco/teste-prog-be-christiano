using JogoDaVelha.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JogoDaVelhaWebApi.Controllers
{
    [Route("api/Tabuleiro")]
    public class TabuleiroController : BaseController
    {
        [HttpGet, Route("obter")]
        public async Task<IActionResult> Obter()
        {
            var resultado = new TabuleiroViewModel();
            return ResponderJsonResult(resultado);
        }
    }
}
