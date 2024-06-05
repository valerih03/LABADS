using Microsoft.EntityFrameworkCore;
using Web_APi_crud.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Carrera> Carreras { get; set; }
    public DbSet<Grupo> Grupos { get; set; }
    public DbSet<Materia> Materias { get; set; }
    public DbSet<Profesor> Profesores { get; set; }
}