using System.ComponentModel;

namespace JogoDaVelha.Negocios.Enums
{
    public enum SituacaoPartida
    {
        [Description("Iniciada")] Iniciada = 0,
        [Description("Empate")] Empate = 1,
        [Description("Vitoria_X")] Vitoria_X = 2,
        [Description("Vitoria_O")] Vitoria_0 = 3
    }
}
