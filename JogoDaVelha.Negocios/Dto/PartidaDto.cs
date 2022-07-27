using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Negocios.Dto
{
    public class PartidaDto
    {
        public int PartidaId { get; set; }
        public JogadorDto JogadorX { get; set; }
        public JogadorDto Jogador0 { get; set; }
        public TabuleiroDto Tabluleiro { get; set; }
        public SituacaoDto Situacao { get; set; }
        public DateTime DataPartida { get; set; }
    }
}
