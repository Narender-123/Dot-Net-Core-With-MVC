using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityFrameworkDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using IdentityFrameworkDemo.Repository;

namespace IdentityFrameworkDemo
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
            //Here we Configure the Services we have to provide the Application
            services.AddDbContext<UserDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("UserDBCS")));
            services.AddControllersWithViews();

            //Here we Configure Identity Framework that will provide Classes to work on the Different Authentication Issues like User Management
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<UserDbContext>();

            //By default the Identity Framework Configure all the Setting For Us
            //But We can also Configure the Setting for Different Options
            services.Configure<IdentityOptions>(options=> 
            {
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 2;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            });

            services.AddControllersWithViews();

            //Here we Add the Repository to make use of  it bu using Dependency Injection
            services.AddScoped<IAccountRepository, AccountRepository>();
//#if DEBUG
//            services.AddRazorPages().AddRazorRunTimeComplilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //To Enable the Middelware we have to use app.useAuthentication();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
