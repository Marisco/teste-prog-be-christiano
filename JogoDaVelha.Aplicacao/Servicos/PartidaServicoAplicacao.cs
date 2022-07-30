using JogoDaVelha.Aplicacao.Interfaces;
using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.Negocios.Enums;
using JogoDaVelha.Negocios.Interfaces.Servicos;

namespace JogoDaVelha.Aplicacao.Servicos
{
    public class PartidaServicoAplicacao : BaseServicoAplicacao<Partida>, IPartidaServicoAplicacao
    {
        private readonly IPartidaServico partidaServico;
        private readonly IJogadorServico jogadorServico;
        private readonly ITabuleiroServico tabuleiroServico;

        public PartidaServicoAplicacao(
            IPartidaServico partidaServico,
            IJogadorServico jogadorServico,
            ITabuleiroServico tabuleiroServico) : base(partidaServico)
        {
            this.partidaServico = partidaServico;
            this.jogadorServico = jogadorServico;
            this.tabuleiroServico = tabuleiroServico;
        }

        public IEnumerable<Partida> ObterTodasPartidas()
        {
            return partidaServico.ObterTodasPartidas();
        }

        public Partida ObterPartida(int Id)
        {
            return partidaServico.ObterPartida(Id);
        }

        public Partida FazerJogada(Partida partidaAtual)
        {
            var jogada = partidaServico.ObterPartida(partidaAtual.PartidaId);

            // TODO Criar método que valida/verifica as jogadas no tabulero para o fim de partida jogador, status etc... antes do update;

            jogada.ProximoTurno = partidaServico.SetProximoTuno(partidaAtual.ProximoTurno.ToString());
            partidaServico.Update(jogada);
            return jogada;
        }

        public Partida IniciarPartida(Partida partidaAtual)
        {
            Partida partida = new Partida()
            {
                Tabluleiro = new Tabuleiro()
                {
                    Posicao = partidaAtual.Tabluleiro.Posicao
                },
                JogadorX = new Jogador()
                {
                    Nome = partidaAtual.JogadorX.Nome

                },
                Jogador0 = new Jogador()
                {
                    Nome = partidaAtual.Jogador0.Nome

                },
                Situacao = new Situacao
                {
                    SituacaoPartida = EnumHelper.GetDescriptionFromEnumValue(SituacaoPartida.Iniciada)
                },
                DataPartida = DateTime.Now,
                ProximoTurno = partidaServico.SetProximoTuno(partidaAtual.ProximoTurno.ToString())
            };

            partidaServico.Add(partida);

            return partida;

        }

    }
}
