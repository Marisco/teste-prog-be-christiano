using JogoDaVelha.Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Dados.EntityConfig
{
    public class SituacaoConfig : EntityTypeConfiguration<Situacao>
    {
        public SituacaoConfig()
        {
            HasKey(c => c.SituacaoId);
            Property(c => c.SituacaoPartida)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
