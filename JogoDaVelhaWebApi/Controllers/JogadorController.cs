using JogoDaVelha.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JogoDaVelhaWebApi.Controllers
{
    [Route("api/Jogador")]
    public class JogadorController : BaseController
    {
        [HttpGet, Route("obter")]
        public async Task<IActionResult> Obter()
        {
            var resultado = new JogadorViewModel(0, "marisco");
            return ResponderJsonResult(resultado);
        }
    }
}
