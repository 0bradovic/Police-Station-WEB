using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PoliceStationWebData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Police_Station_WEB
{
    public class DesignTimeDbContextFactory: IDesignTimeDbContextFactory<PoliceStationWebDataContext>
    {

        public PoliceStationWebDataContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<PoliceStationWebDataContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString,
                     x => x.MigrationsAssembly("Police Station WEB"));

            return new PoliceStationWebDataContext(builder.Options);


            
        }



    }
}
