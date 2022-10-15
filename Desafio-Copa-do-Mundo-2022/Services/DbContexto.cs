using API_Copa_do_Mundo_2022.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Copa_do_Mundo_2022.Services
{
    public class DbContexto :DbContext
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
    }
}
