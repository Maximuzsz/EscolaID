using EscolaID.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaID.Data
{
    public class EscolaIdDBContex : DbContext
    {
        public EscolaIdDBContex(DbContextOptions<EscolaIdDBContex> options)
            : base(options) 
        {

        }

        public DbSet<EscolaModel> Escolas { get; set; }
        public DbSet<TurmaModel> Turmas { get; set; }
        public DbSet<AlunosModel> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
