using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Negocios.Entidades
{
    public class Tabuleiro
    {
        public int TabuleiroId { get; set; }        
        public string[][] Posicao { get; set; }
    }
}
