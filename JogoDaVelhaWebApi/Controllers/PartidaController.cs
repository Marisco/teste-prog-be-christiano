using JogoDaVelha.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JogoDaVelhaWebApi.Controllers
{
    [Route("api/Partida")]
    public class PartidaController : BaseController
    {
        [HttpGet, Route("obter")]
        public async Task<IActionResult> Obter()
        {
            var resultado = new PartidaViewModel();
            return ResponderJsonResult(resultado);
        }
        [HttpGet, Route("iniciar")]
        public async Task<IActionResult> Iniciar()
        {
            var resultado = new PartidaViewModel();
            return ResponderJsonResult(resultado);
        }

        [HttpGet, Route("jogar")]
        public async Task<IActionResult> Jogar()
        {
            var resultado = new PartidaViewModel();
            return ResponderJsonResult(resultado);
        }
        
    }
}
