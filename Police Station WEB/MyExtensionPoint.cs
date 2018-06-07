using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PoliceStationWebData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Police_Station_WEB
{
    public static class MyExtensionPoint
    {
    
        public static IServiceCollection AddMyLibraryDbContext(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<PoliceStationWebDataContext>(options => options.UseSqlServer(Configuration["DefaultConnection"]));
            return services;
        }



        /*
         options.UseSqlServer(connectionString)
         .MigrationsAssembly("BaseApp.Data.ProjectMigration");
       */
    }
}
