using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Negocios.Entidades
{
    public class Partida
    {
        public int PartidaId { get; set; }        
        public Jogador JogadorX { get; set; }
        public Jogador Jogador0 { get; set; }        
        public Tabuleiro Tabluleiro { get; set; }
        public Situacao Situacao { get; set; }        
        public char ProximoTurno { get; set; }        
        public DateTime DataPartida { get; set; }
        
    }
}
