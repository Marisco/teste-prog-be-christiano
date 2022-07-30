using System;
using System.ComponentModel.DataAnnotations;


namespace JogoDaVelha.WebApi.ViewModels
{
    public class TabuleiroViewModel
    {
        [Key]
        public int TabuleiroId { get; set; }        
        public string[][] Posicao { get; set; }        
    }
}
