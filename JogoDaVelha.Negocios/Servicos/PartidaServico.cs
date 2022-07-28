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

        public IEnumerable<Partida> BuscarPartidas(int Id)
        {
            return partidaRepositorio.BuscarPartidas(Id);
        }

        public char SetProximoTuno(char turnoAtual)
        {
            return turnoAtual  == 'X' ? '0' : 'X';
        }
    }
}
