using System;
using System.ComponentModel.DataAnnotations;


namespace JogoDaVelha.WebApi.ViewModels
{
    public class PartidaViewModel
    {
        [Key]
        public int PartidaId { get; set; }        
        public JogadorViewModel JogadorX { get; set; }
        public JogadorViewModel Jogador0 { get; set; }        
        public TabuleiroViewModel Tabluleiro { get; set; }
        public SituacaoViewModel Situacao { get; set; }        
        public char ProximoTurno { get; set; }
        public DateTime DataPartida { get; set; }
    }
}
