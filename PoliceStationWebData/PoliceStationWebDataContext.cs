using Microsoft.EntityFrameworkCore;
using PoliceStationWebData;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace PoliceStationWebData
{
    public class PoliceStationWebDataContext : DbContext
    {
        public PoliceStationWebDataContext(DbContextOptions options):base(options) { }
        
        public DbSet<AlarmniSistem> AlarmniSistem_ { get; set; }

        public DbSet<Ultrazvucni> Ultrazvucni_ { get; set; }
        public DbSet<Pokretni> Pokretni_ { get; set; }
        public DbSet<Toplotni> Toplotni_ { get; set; }

        public DbSet<Cin> Cin_ { get; set; }

        public DbSet<Objekat> Objekat_ { get; set; }

        public DbSet<Ostali> Ostali_ { get; set; }

        public DbSet<Patrola> Patrola_ { get; set; }

        public DbSet<Policajac> Policajac_ { get; set; }

        public DbSet<PolicijskaStanica> PolicijskaStanica_ { get; set; }

        public DbSet<Pozornik> Pozornik_ { get; set; }

        public DbSet<Skola> Skola_ { get; set; }

        public DbSet<Skolski> Skolski_ { get; set; }

        public DbSet<TehnickoLice> TehnickoLice_ { get; set; }

        public DbSet<Ulica> Ulica_ { get; set; }

        public DbSet<Uprava> Uprava_ { get; set; }

        public DbSet<Ustanova> Ustanova_ { get; set; }

        public DbSet<VanredneSituacije> VanredneSituacije_ { get; set; }

        public DbSet<Vozilo> Vozilo_ { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*
            modelBuilder.Entity<Patrola>()
                .HasKey(x => x.Redni_br);

            modelBuilder.Entity<Ostali>()
                .HasKey(x => x.Redni_br_patrole);


            modelBuilder.Entity<PatrolaOstali>()
                .HasKey(t => new { t.Redni_br, t.Redni_br_patrole });

            modelBuilder.Entity<PatrolaOstali>()
                .HasOne(pt => pt.Patrola)
                .WithMany(p => p.PatrolaOstali_)
                .HasForeignKey(pt => pt.Redni_br);

            modelBuilder.Entity<PatrolaOstali>()
                .HasOne(pt => pt.Ostali)
                .WithMany(t => t.PatrolaOstali_)
                .HasForeignKey(pt => pt.Redni_br_patrole);
            */
        }
        
    
    

    }
}
