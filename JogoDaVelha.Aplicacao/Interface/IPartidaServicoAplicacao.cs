using JogoDaVelha.Negocios.Entidades;

namespace JogoDaVelha.Aplicacao.Interfaces
{
    public interface IPartidaServicoAplicacao : IBaseServicoAplicacao<Partida>
    {
        Partida IniciarPartida(Partida partidaAtual);
        Partida ObterPartida(int Id);
        IEnumerable<Partida> ObterTodasPartidas();
        Partida FazerJogada(Partida partidaAtual);
    }
}
