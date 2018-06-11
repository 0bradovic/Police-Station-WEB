using Microsoft.EntityFrameworkCore;
using PoliceStationWebData;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace PoliceStationWebData
{
    public class PoliceStationWebDataContext : DbContext
    {

        public PoliceStationWebDataContext() { }
        public PoliceStationWebDataContext(DbContextOptions options):base(options) { }
        
        public virtual DbSet<AlarmniSistem> AlarmniSistem_ { get; set; }

        public virtual DbSet<Ultrazvucni> Ultrazvucni_ { get; set; }
        public virtual DbSet<Pokretni> Pokretni_ { get; set; }
        public virtual DbSet<Toplotni> Toplotni_ { get; set; }

        public virtual DbSet<Cin> Cin_ { get; set; }

        public virtual DbSet<Objekat> Objekat_ { get; set; }

        public virtual DbSet<Ostali> Ostali_ { get; set; }

        public virtual DbSet<Patrola> Patrola_ { get; set; }

        public virtual DbSet<Policajac> Policajac_ { get; set; }

        public virtual DbSet<PolicijskaStanica> PolicijskaStanica_ { get; set; }

        public virtual DbSet<Pozornik> Pozornik_ { get; set; }

        public virtual DbSet<Skola> Skola_ { get; set; }

        public virtual DbSet<Skolski> Skolski_ { get; set; }

        public virtual DbSet<TehnickoLice> TehnickoLice_ { get; set; }

        public virtual DbSet<Ulica> Ulica_ { get; set; }

        public virtual DbSet<Uprava> Uprava_ { get; set; }

        public virtual DbSet<Ustanova> Ustanova_ { get; set; }

        public virtual DbSet<VanredneSituacije> VanredneSituacije_ { get; set; }

        public virtual DbSet<Vozilo> Vozilo_ { get; set; }

        
        
         /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

    

    }
}
