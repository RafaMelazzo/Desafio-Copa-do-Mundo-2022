using API_Copa_do_Mundo_2022.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace API_Copa_do_Mundo_2022.Services
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

        public DbContexto() { }

        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Fase> Fases { get; set; }
        public DbSet<Clube> Clubes { get; set; }
        public DbSet<Partida> Partidas { get; set; }
        public DbSet<PartidaClube> PartidasClubes { get; set; }
        public DbSet<Estatistica> Estatisticas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PartidaClube>()
                .HasKey(pc => new { pc.PartidaId, pc.ClubeIdA, pc.ClubeIdB });
            modelBuilder.Entity<PartidaClube>()
                .HasOne(pc => pc.Partida)
                .WithMany(p => p.PartidasClubes)
                .HasForeignKey(pc => pc.PartidaId);
            modelBuilder.Entity<PartidaClube>()
                .HasOne(pc => pc.ClubeA)
                .WithMany(c => c.PartidasClubesA)
                .HasForeignKey(pc => pc.ClubeIdA);
            modelBuilder.Entity<PartidaClube>()
                .HasOne(pc => pc.ClubeB)
                .WithMany(c => c.PartidasClubesB)
                .HasForeignKey(pc => pc.ClubeIdB);
        }
    }
}
