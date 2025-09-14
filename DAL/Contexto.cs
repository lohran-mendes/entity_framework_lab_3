using entity_framework_lab_3.Models;
using Microsoft.EntityFrameworkCore;

namespace entity_framework_lab_3.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Models.Turma> Turmas { get; set; }
    public DbSet<Models.Professor> Professores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Models.Turma>().HasOne(t => t.Professor).WithMany(p => p.Turmas)
            .HasForeignKey(t => t.ProfessorId).OnDelete(DeleteBehavior.Restrict);
        
        base.OnModelCreating(modelBuilder);
    }
}