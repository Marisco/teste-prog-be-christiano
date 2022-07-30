using JogoDaVelha.Aplicacao.Interfaces;
using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using JogoDaVelha.Aplicacao.Dto;

namespace JogoDaVelhaWebApi.Controllers
{
    [Route("api/Partida")]
    public class PartidaController : BaseController
    {
        private readonly IMapper mapper;
        private readonly IPartidaServicoAplicacao partidaServicoAplicacao;
        

        public PartidaController(IMapper mapper, 
            IPartidaServicoAplicacao partidaServicoAplicacao            
            )
        {
            this.mapper = mapper;
            this.partidaServicoAplicacao = partidaServicoAplicacao;            
        }

        [HttpGet, Route("obter")]
        public async Task<IActionResult> Obter()
        {
            var partida = partidaServicoAplicacao.ObterTodasPartidas();
            var resultado = mapper.Map<List<PartidaViewModel>>(partida);
            return ResponderJsonResult(resultado);
        }

        [HttpPost, Route("iniciar")]
        public async Task<IActionResult> Iniciar([FromBody] PartidaViewModel partidaViewMoldel)
        {
            //Esse método irá registrar uma nova partida.
            var partidaAtual = mapper.Map<Partida>(partidaViewMoldel);
            var partida = partidaServicoAplicacao.IniciarPartida(partidaAtual);            
            var resultado = mapper.Map<PartidaViewModel>(partida);            
            return ResponderJsonResult(resultado);
            
        }

        [HttpPost, Route("jogar")]
        public async Task<IActionResult> Jogar([FromBody] PartidaViewModel partidaViewMoldel)
        {
            var partidaAtual = mapper.Map<Partida>(partidaViewMoldel);
            var partida = partidaServicoAplicacao.FazerJogada(partidaAtual);
            var resultado = mapper.Map<PartidaViewModel>(partida);
            return ResponderJsonResult(resultado);
        }
        
    }
}
