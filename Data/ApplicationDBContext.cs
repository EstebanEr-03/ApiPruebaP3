using Microsoft.EntityFrameworkCore;
using API_PRUEBA_PROGRESO3.Models;

using API_PRUEBA_PROGRESO3.Controllers;

namespace API_PRUEBA_PROGRESO3.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext
            (
                DbContextOptions<ApplicationDBContext> options
            ) : base(options)
        {

        }

        // Creacion tabla BDD
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<Resultado> Resultados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarea>().HasData(

                new Tarea
                {
                    idTarea = 1,
                    nombreTarea = "Matematicas",
                    descripcionTarea = "20 ejercicios",
                    estadoTarea = "Pendiente"
                }
                );
        }
    }
}