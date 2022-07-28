using JogoDaVelha.Negocios.Entidades;
using JogoDaVelha.Negocios.Interfaces.Repositorios;

namespace JogoDaVelha.Dados.Repositorios
{
    public class PartidaRepositorio : BaseRepositorio<Partida>, IPartidaRepositorio
    {
        public IEnumerable<Partida> BuscarPartidas(int Id)
        {
            return Db.Partida.Where(p => p.PartidaId == Id);
        }
    }
}
