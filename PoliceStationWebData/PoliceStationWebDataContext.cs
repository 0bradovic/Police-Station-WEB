using Microsoft.EntityFrameworkCore;
using PoliceStationWebData.Models;
using System;


namespace PoliceStationWebData
{
    public class PoliceStationWebDataContext : DbContext
    {
        public PoliceStationWebDataContext(DbContextOptions options):base(options) { }
        
        public DbSet<Patron> Patrons { get; set; } 



        public DbSet<AlarmniSistem> AlarmniSistem_ { get; set; }

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

    }
}
