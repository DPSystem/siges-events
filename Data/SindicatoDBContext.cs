using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shared.Models.Sindicato;

namespace Data
{
    public class SindicatoDBcontext : DbContext
    {
        public SindicatoDBcontext() { }

        public SindicatoDBcontext(DbContextOptions<SindicatoDBcontext> options)
            : base(options) { }

        public DbSet<Maesoc> Maesoc { get; set; }
        public DbSet<Soccen> Soccen { get; set; }
        public DbSet<Ddjj> ddjj { get; set; }
        public DbSet<Ddjjt> ddjjt { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Ignorar la entidad Maesoc si ya existe
            //builder.Entity<Maesoc>().ToTable("Maesoc", t => t.ExcludeFromMigrations());
            builder.Entity<Maesoc>().ToTable("maesoc", "fotos_", t => t.ExcludeFromMigrations());
            // Ignorar la entidad Maesoc si ya existe
            //builder.Entity<Soccen>().ToTable("Soccen", t => t.ExcludeFromMigrations());
            builder.Entity<Soccen>().ToTable("soccen", "fotos_", t => t.ExcludeFromMigrations());

            builder.Entity<Ddjj>().ToTable("ddjj", t => t.ExcludeFromMigrations());
            builder.Entity<Ddjjt>().ToTable("ddjjt", t => t.ExcludeFromMigrations());

            builder.Entity<Maesoc>().HasKey(u => u.MAESOC_CUIL);
            builder.Entity<Soccen>().HasKey(u => u.SOCCEN_CUIL);
        }
    }
}
