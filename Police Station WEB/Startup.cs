﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Police_Station_WEB.Data;
using Police_Station_WEB.Models;
using Police_Station_WEB.Services;
using PoliceStationWebData;
using PoliceStationWebServices;

namespace Police_Station_WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            string dbConnectionString = Configuration.GetConnectionString("DefaultConnection");
            string assemblyName = typeof(PoliceStationWebDataContext).Namespace;//*

            services.AddDbContext<PoliceStationWebDataContext>(options =>
                 options.UseSqlServer(dbConnectionString,
                  optionsBuilder =>
                optionsBuilder.MigrationsAssembly(assemblyName)
             ));
             

            //services.AddDbContext<ApplicationDbContext>(options =>
                //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();

            services.AddSingleton(Configuration);
            services.AddScoped<IPoliceStationWebPolicajac, PoliceStationWebDataPolicajacService>();



            //services.AddDbContext<PoliceStationWebDataContext>(options 
              //  => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //-------------^^
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
