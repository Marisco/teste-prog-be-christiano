using JogoDaVelha.Negocios.Interfaces.Servicos;
using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.Negocios.Interfaces.Repositorios;

namespace JogoDaVelha.Negocios.Servicos
{
    public class SituacaoServico : BaseServico<Situacao>, ISituacaoServico
    {

        private readonly ISituacaoRepositorio situacaoRepositorio;

        public SituacaoServico(ISituacaoRepositorio situacaoRepositorio) : base(situacaoRepositorio)
        {
            this.situacaoRepositorio = situacaoRepositorio;
        }
    }
}
