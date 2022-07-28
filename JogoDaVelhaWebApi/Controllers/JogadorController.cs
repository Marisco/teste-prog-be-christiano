using JogoDaVelha.Aplicacao.Interfaces;
using JogoDaVelha.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using JogoDaVelha.Negocios.Entidades;

namespace JogoDaVelhaWebApi.Controllers
{
    [Route("api/Jogador")]
    public class JogadorController : BaseController
    {
        private readonly IMapper mapper;
        private readonly IJogadorServicoAplicacao jogadorServicoAplicacao;
        

        public JogadorController(IMapper mapper, IJogadorServicoAplicacao jogadorServicoAplicacao) 
        {
            this.mapper = mapper;
            this.jogadorServicoAplicacao = jogadorServicoAplicacao;
            
        }
        [HttpGet, Route("obter")]
        public async Task<IActionResult> Obter()
        {
            var jogador = jogadorServicoAplicacao.GetAll();
            var resultado = mapper.Map<List<JogadorViewModel>>(jogador);
            return ResponderJsonResult(resultado);
        }
    }
}
