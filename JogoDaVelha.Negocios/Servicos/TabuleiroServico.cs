using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.Negocios.Interfaces.Repositorios;
using JogoDaVelha.Negocios.Interfaces.Servicos;
namespace JogoDaVelha.Negocios.Servicos
{
    public  class TabuleiroServico : BaseServico<Tabuleiro>, ITabuleiroServico
    {
        private readonly ITabuleiroRepositorio tabuleiroRepositorio;

        public TabuleiroServico(ITabuleiroRepositorio tabuleiroRepositorio) : base(tabuleiroRepositorio)
        {
            this.tabuleiroRepositorio = tabuleiroRepositorio;
        }

        public void ValidarTabuleiro()
        {

        }

        public void ValidarJogada()
        {

        }
        public void ValidarPosicao()
        {

        }
        public void GetSAtatus()
        {

        }
    }
}
