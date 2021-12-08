using Microsoft.EntityFrameworkCore;
using SmarthSchool.API.Models;

namespace SmarthSchool.API.Data
{
    public class SmarthContext : DbContext
    {
        public SmarthContext(DbContextOptions<SmarthContext> options) : base(options){ }
        public DbSet<Aluno> Alunos{ get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<AlunoDisciplina> AlunoDisciplinas { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlunoDisciplina>()
                .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });

        }

    }
}
