<<<<<<< HEAD
﻿using Admin.Core;
using Microsoft.AspNetCore.Builder;
=======
﻿using Microsoft.AspNetCore.Builder;
>>>>>>> parent of 43d4c40... .
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whereisthelove.Data.Dal;
using Whereisthelove.Data.Dal.Abstract;
using Whereisthelove.Data.Dal.Concrete;
using Whereisthelove.Data.Domain.Entities;

namespace Admin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:50000").AllowAnyHeader().AllowAnyMethod();
                    });
            });

            var entityContextDB = Configuration.GetConnectionString("EntityContextDB");
            services.AddDbContext<EntityContext>(opt => opt.UseSqlServer(entityContextDB));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IFileManager, FileManager>();
            services.AddControllersWithViews();
<<<<<<< HEAD
            services.AddAuthentication("CookieAuth")
                .AddCookie("CookieAuth", x =>
                {
                    x.Cookie.Name = "Grandmas.Cookie";
                    x.LoginPath = "/Account/SignIn";
                });
=======
>>>>>>> parent of 43d4c40... .
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,EntityContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            bool itCreated = db.Database.EnsureCreated();
            if (itCreated)
            {
                db.ApplicationAdmins.Add(new ApplicationAdmin()
                {
                    Id = Guid.NewGuid(),
                    Email = "admin@gmail.com",
                    Password = "123",
                    UserName = "IhsanOmer"
                });
                db.SaveChanges();
            }
            app.UseRouting();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Anasayfa}/{action=Index}/{id?}");
            });
        }
    }
}
