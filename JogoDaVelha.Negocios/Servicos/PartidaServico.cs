using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.Negocios.Interfaces.Repositorios;
using JogoDaVelha.Negocios.Interfaces.Servicos;

namespace JogoDaVelha.Negocios.Servicos
{
    public class PartidaServico : BaseServico<Partida>, IPartidaServico
    {
        private readonly IPartidaRepositorio partidaRepositorio;

        public PartidaServico(IPartidaRepositorio partidaRepositorio) : base(partidaRepositorio)
        {
            this.partidaRepositorio = partidaRepositorio;
        }

        public Partida ObterPartida(int Id)
        {
            return partidaRepositorio.ObterPartida(Id);
        }

        public IEnumerable<Partida> ObterTodasPartidas()
        {
            return partidaRepositorio.ObterTodasPartidas();
        }

        public char SetProximoTuno(string turnoAtual)
        {
            return turnoAtual  == "X" ? '0' : 'X';
        }
    }
}
