using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Parcial2_ap1_20180618.Entidades;
using System.Threading.Tasks;

namespace Parcial2_ap1_20180618.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Proyectos> Proyectos { get; set; }
        public DbSet<ProyectosDetalle> ProyectosDetalle { get; set; }
        public DbSet<TiposTareas> TiposTareas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA/GestionProyectos.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TiposTareas>().HasData(
               new TiposTareas() { TipoId = 1, Descripcion = "Análisis", Requerimiento = "Analizar la opción de clientes", Tiempo = 120 },
               new TiposTareas() { TipoId = 2, Descripcion = "Diseño", Requerimiento = "Hacer un diseño excelente", Tiempo = 60 },
               new TiposTareas() { TipoId = 3, Descripcion = "Programación", Requerimiento = "Programar todo el registro", Tiempo = 240 },
               new TiposTareas() { TipoId = 4, Descripcion = "Prueba", Requerimiento = "Probar con mucho cuidado", Tiempo = 30 }
           );
        }
    }
}
