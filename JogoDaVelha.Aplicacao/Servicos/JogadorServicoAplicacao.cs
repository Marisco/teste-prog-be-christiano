using JogoDaVelha.Aplicacao.Interfaces;
using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.Negocios.Interfaces.Servicos;

namespace JogoDaVelha.Aplicacao.Servicos
{
    public class JogadorServicoAplicacao : BaseServicoAplicacao<Jogador>, IJogadorServicoAplicacao
    {
        private readonly IJogadorServico jogadorServico;

        public JogadorServicoAplicacao(IJogadorServico jogadorServico) : base(jogadorServico)
        {
            this.jogadorServico = jogadorServico;
        }
    }
}
