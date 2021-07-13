using Ecomerece_Web.Data;
using Ecomerece_Web.Models;
using Ecomerece_Web.Services.Implements;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web
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
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection"));
                //options.UseLazyLoadingProxies(true);
            });
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<Ecomerece_Web.Data.User>(
                options => options.User.RequireUniqueEmail = true
                //options => options.SignIn.RequireConfirmedAccount = true
                )
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            //enable lazy load
            //services.AddEntityFrameworkProxies();
            services.AddScoped<IProductRepository<Product>, ProductService>();
            //services.AddScoped<IUserRepository<User>, UserService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                //endpoints.MapControllerRoute(
                //    name: "ultility",
                //    pattern: "{controller=Utility}/{action=get}/{imageFile}");
                //endpoints.MapRazorPages();
            });
            //Seeding create admin when the project if is initialized
            //using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            //{
            //    var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();
            //    var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
            //    Task task1 = Seed.SeedRolesAsync(userManager, roleManager);

            //    task1.Wait();

            //    var userManager2 = serviceScope.ServiceProvider.GetService<UserManager<User>>();
            //    var roleManager2 = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
            //    Task task2 = Seed.SeedAdminAsync(userManager2, roleManager2);
            //    task2.Wait();

            //}
        }
    }
}
