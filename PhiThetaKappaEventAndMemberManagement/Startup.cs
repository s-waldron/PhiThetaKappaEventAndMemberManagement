﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PhiThetaKappaEventAndMemberManagement.Models;

namespace PhiThetaKappaEventAndMemberManagement
{
    public class Startup
    {
        IConfigurationRoot Configuration;

        public Startup (IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }// end Startup constructor
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddTransient<IEventsRepository, EFEventsRepository>();
            services.AddTransient<IMemberRepository, EFMemberRepository>();
            services.AddTransient<INewsRepository, EFNewsRepository>();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }// end ConfigureServices method

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseDeveloperExceptionPage();
            app.UseSession();
            app.UseStaticFiles();
            //app.UseIdentity();
            app.UseMvcWithDefaultRoute();
        }// end Configure method
    }// end Startup class
}// end PhiThetaKappaEventAndMemberManagement namespace