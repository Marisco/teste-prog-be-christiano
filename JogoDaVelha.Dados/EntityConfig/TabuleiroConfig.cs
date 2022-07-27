using JogoDaVelha.Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Dados.EntityConfig
{
    public class TabuleiroConfig : EntityTypeConfiguration<Tabuleiro>
    {
        public TabuleiroConfig()
        {
            HasKey(c => c.TabuleiroId);            
        }
    }
}
