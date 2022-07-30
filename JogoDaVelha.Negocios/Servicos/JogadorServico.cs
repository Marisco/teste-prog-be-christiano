using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.Negocios.Interfaces.Repositorios;
using JogoDaVelha.Negocios.Interfaces.Servicos;

namespace JogoDaVelha.Negocios.Servicos
{
    public class JogadorServico : BaseServico<Jogador>, IJogadorServico
    {
        private readonly IJogadorRepositorio jogadorRepositorio;

        public JogadorServico(IJogadorRepositorio jogadorRepositorio) : base(jogadorRepositorio)
        {
            this.jogadorRepositorio = jogadorRepositorio;
            
        }        
    }
}
