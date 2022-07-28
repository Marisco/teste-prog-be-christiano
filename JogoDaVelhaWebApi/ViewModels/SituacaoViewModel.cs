using System;
using System.ComponentModel.DataAnnotations;


namespace JogoDaVelha.WebApi.ViewModels
{
    public class SituacaoViewModel
    {
        [Key] 
        public int SituacaoId { get; set; }
        public string SituacaoPartida { get; set; }
        

    }
}
