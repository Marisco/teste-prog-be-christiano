using System;
using System.ComponentModel.DataAnnotations;


namespace JogoDaVelha.WebApi.ViewModels
{
    public class JogadorViewModel
    {

        [Key] 
        public int JogadorId { get; set; }
        public string Nome { get; set; }

        public JogadorViewModel(int jogadorId, string nome)
        {
            this.JogadorId = jogadorId;
            this.Nome = nome;
        }
    }
}
