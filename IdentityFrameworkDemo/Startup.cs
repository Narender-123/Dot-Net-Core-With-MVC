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
using IdentityFrameworkDemo.Helpers;
using IdentityFrameworkDemo.Services;

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
            //But We can also Configure the Setting for Different Options(In this Case Password)
            services.Configure<IdentityOptions>(options=> 
            {
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 2;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            });

            //Here we register the SMTPConfigModel to SMTPConfig 
            services.Configure<SMTPConfigModel>(Configuration.GetSection("SMTPConfig"));


            //Here we have to Configure Settings for Redirection to Login Page
            services.ConfigureApplicationCookie(config => 
            {
                //config.LoginPath = "/login";
                config.LoginPath = Configuration["Application:LoginPath"];
            });

            services.AddControllersWithViews();

            //Here we Add the Repository to make use of  it bu using Dependency Injection
            services.AddScoped<IAccountRepository, AccountRepository>();

            //Here we have to tell the Application of Our UserClaimsPrincipalFactory
            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUserClaimsPrincipleFactory>();

            //Here We Add the Service which we are Using to Get the User Id From HttpContext
            services.AddScoped<IUserService, UserService>();

            //Here we add the EmailSerive Using SMTP to send the emails
            services.AddScoped<IEmailService, EmailService>();

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

            //To Enable the Middelware called Authentication, we have to use app.useAuthentication();
            app.UseAuthentication();

            //Authorization can be Applied to action Level or Controller Level
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
