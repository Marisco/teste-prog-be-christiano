using JogoDaVelha.Dados.EntityConfig;
using JogoDaVelha.Negocios.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace JogoDaVelha.Dados.Contexto
{
    public class JogoDaVelhaContexto : DbContext
    {
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Partida> Partida { get; set; }
        public DbSet<Tabuleiro> Tabuleiro { get; set; }
        public DbSet<Situacao> Situacao { get; set; }

        public JogoDaVelhaContexto() : base("JogoDaVelha")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new JogadorConfig());
            modelBuilder.Configurations.Add(new PartidaConfig());
            modelBuilder.Configurations.Add(new SituacaoConfig());
            modelBuilder.Configurations.Add(new TabuleiroConfig());           

        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataPartida") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataPartida").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataPartida").IsModified = false;
                }

            }

            return base.SaveChanges();

        }

       

    }
}
