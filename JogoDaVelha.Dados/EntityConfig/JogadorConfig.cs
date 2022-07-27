using JogoDaVelha.Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Dados.EntityConfig
{
    public class JogadorConfig : EntityTypeConfiguration<Jogador>
    {
        public JogadorConfig()
        {
            HasKey(c => c.JogadorId);
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
