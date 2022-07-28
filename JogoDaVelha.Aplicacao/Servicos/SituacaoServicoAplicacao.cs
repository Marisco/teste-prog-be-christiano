using JogoDaVelha.Aplicacao.Interfaces;
using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.Negocios.Interfaces.Servicos;

namespace JogoDaVelha.Aplicacao.Servicos
{
    public  class SituacaoServicoAplicacao : BaseServicoAplicacao<Situacao>, ISituacaoServicoAplicacao
    {

        private readonly ISituacaoServico situacaoServico;

        public SituacaoServicoAplicacao(ISituacaoServico situacaoServico) : base(situacaoServico)
        {
            this.situacaoServico = situacaoServico;
        }
    }
}
