using JogoDaVelha.Aplicacao.Interfaces;
using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.Negocios.Interfaces.Servicos;

namespace JogoDaVelha.Aplicacao.Servicos
{
    public  class TabuleiroServicoAplicacao : BaseServicoAplicacao<Tabuleiro>, ITabuleiroServicoAplicacao
    {
        private readonly ITabuleiroServico tabuleiroServico;

        public TabuleiroServicoAplicacao(ITabuleiroServico tabuleiroServico) : base(tabuleiroServico)
        {
            this.tabuleiroServico = tabuleiroServico;
        }
    }
}
