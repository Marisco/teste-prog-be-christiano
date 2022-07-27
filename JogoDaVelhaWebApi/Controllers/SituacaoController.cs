using JogoDaVelha.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JogoDaVelhaWebApi.Controllers
{
    [Route("api/Situacao")]
    public class SituacaoController : BaseController
    {
        [HttpGet, Route("obter")]
        public async Task<IActionResult> Obter()
        {
            var resultado = new SituacaoViewModel();
            return ResponderJsonResult(resultado);
        }
    }
}
