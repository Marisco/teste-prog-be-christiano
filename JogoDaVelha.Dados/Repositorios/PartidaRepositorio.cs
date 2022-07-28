using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.Negocios.Interfaces.Repositorios;
using System.Data.Entity;

namespace JogoDaVelha.Dados.Repositorios
{
    public class PartidaRepositorio : BaseRepositorio<Partida>, IPartidaRepositorio
    {
        public Partida ObterPartida(int Id)
        {
            return Db.Partida
                .Where(p => p.PartidaId == Id)
                .Include(j => j.Jogador0)
                .Include(j => j.JogadorX)
                .Include(t => t.Tabluleiro)
                .Include(s => s.Situacao).FirstOrDefault();
        }

        public IEnumerable<Partida> ObterTodasPartidas()
        {
            return Db.Partida.
                Include(j => j.Jogador0)
                .Include(j => j.JogadorX)
                .Include(t => t.Tabluleiro)
                .Include(s => s.Situacao);
        }

    }
}
