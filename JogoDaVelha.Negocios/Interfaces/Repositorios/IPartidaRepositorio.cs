using JogoDaVelha.Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Negocios.Interfaces.Repositorios
{
    public interface IPartidaRepositorio : IBaseRepositorio<Partida>
    {
        IEnumerable<Partida> BuscarPartidas(int Id);
    }
}
