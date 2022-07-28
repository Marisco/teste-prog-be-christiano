using JogoDaVelha.Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Negocios.Interfaces.Servicos
{
    public interface IPartidaServico: IBaseServico<Partida>
    {
        Partida ObterPartida(int Id);
        IEnumerable<Partida> ObterTodasPartidas();
        char SetProximoTuno(string turnoAtual);
    }
}
