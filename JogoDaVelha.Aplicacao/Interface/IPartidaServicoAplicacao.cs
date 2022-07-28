using JogoDaVelha.Negocios.Entidades;

namespace JogoDaVelha.Aplicacao.Interfaces
{
    public interface IPartidaServicoAplicacao : IBaseServicoAplicacao<Partida>
    {
        Partida IniciarPartida();
        IEnumerable<Partida> BuscarPartidas(int Id);
        Partida FazerJogada(Partida partidaAtual);
    }
}
