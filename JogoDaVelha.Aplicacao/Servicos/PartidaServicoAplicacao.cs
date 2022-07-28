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
            this.tabuleiroServico = tabuleiroServico
        }

        public IEnumerable<Partida> BuscarPartidas(int Id)
        {
            return partidaServico.BuscarPartidas(Id);
        }

        public Partida FazerJogada(Partida partidaAtual)
        {
            var jogada = partidaServico.GetById(partidaAtual.PartidaId);
            // TODO Verificacar tabulero para fim de partida e setar status da partida antes do update;
            jogada.ProximoTurno = partidaServico.SetProximoTuno(partidaAtual.ProximoTurno);
            partidaServico.Update(jogada);
            return jogada;
        }

            public Partida IniciarPartida()
        {
            Tabuleiro tabuleiro = new Tabuleiro();
            string[] posicao = { " ' - ', ' - ', ' - ', ' - ', ' - ', ' - ', ' - ', ' - ', ' - '" };
            tabuleiro.Posicao = posicao;

            Jogador jogador_x = new Jogador();
            jogador_x.Nome = "jogador_x";
            Jogador jogador_0 = new Jogador();
            jogador_0.Nome = "jogador_0";
            
            Situacao situacao = new Situacao();
            situacao.SituacaoPartida = EnumHelper.GetDescriptionFromEnumValue(SituacaoPartida.Iniciada);

            Partida partida = new Partida();
            partida.Tabluleiro = tabuleiro;
            partida.JogadorX = jogador_x;
            partida.Jogador0 = jogador_0;
            partida.Situacao = situacao;
            partida.DataPartida = DateTime.Now;
            partida.ProximoTurno = partidaServico.SetProximoTuno(' ');
            partidaServico.Add(partida);

            return partida;

        }

    }
}
