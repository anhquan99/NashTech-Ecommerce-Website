using Ecomerece_Web.Data;
using Ecomerece_Web.Data.Prototype;
using Ecomerece_Web.Models;
using Ecomerece_Web.Services;
using Ecomerece_Web.Services.Adapter;
using Ecomerece_Web.Services.Implements;
using Ecomerece_Web.Services.Interfaces;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
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
            //services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<Ecomerece_Web.Data.User>(
                options => options.User.RequireUniqueEmail = true
                //options => options.SignIn.RequireConfirmedAccount = true
                )
                .AddRoles<IdentityRole>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();


            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            //enable lazy load
            //services.AddEntityFrameworkProxies();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("admin", policyAdmin =>
                {
                    policyAdmin.RequireClaim("role", "admin");
                });
            });
            //CORS
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder
                        .WithOrigins(Configuration["SPAClient:URL"])
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                    });
            });

            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(options =>
                {
                    // base-address of your identityserver
                    options.Authority = Configuration["IDS:URL"];
                    // name of the API resource
                    options.ApiName = Configuration["IDS:API_NAME"];
                });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "IdentityServer.Demo.Api",
                        Version = "v1",
                    });
                c.CustomSchemaIds(x => x.FullName);
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme."
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,

                        },
                        new List<string>()
                    }
                });
            });

            //https://weblog.west-wind.com/posts/2021/Mar/09/Role-based-JWT-Tokens-in-ASPNET-Core#setting-up-jwt-authentication-and-authorization
            //services.AddAuthentication(auth =>
            //{
            //    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(options =>
            //{
            //    options.SaveToken = true;
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuer = true,
            //        ValidIssuer = "any",
            //        ValidateAudience = true,
            //        ValidAudience = "any",
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("e991736ba4e6609f778b7217e1892354b8bdaf28baf7c1add58fcd6764a6ce6f"))
            //    };
            //});

            services.AddScoped<IProductRepository<Product>, ProductService>();
            services.AddScoped<IUserRepository<User>, UserService>();
            services.AddScoped<IAdapter<User, UserPrototype>, UserAdapter>();
            services.AddScoped<IAdapter<Product, ProductPrototype>, ProductAdapter>();
            services.AddScoped<IAdapter<User, UserPrototype>, UserAdapter>();
            services.AddScoped<FileService>();

            services.AddScoped<IRepository<Brand>, BrandService>();
            services.AddScoped<IRepository<Category>, CategoryService>();
            services.AddScoped<IRepository<Silhouette>, SilhouetteService>();
            services.AddScoped<IRepository<Ecomerece_Web.Data.Type>, TypeService>();
            services.AddScoped<IRepository<Color>, ColorService>();
            //services.AddScoped<IUserRepository<User>, UserService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
                app.UseSwagger();

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("v1/swagger.json", "MyAPI V1");
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //CORS
            app.UseCors();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();




            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            //Seeding create admin when the project if is initialized
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                Task task1 = Seed.SeedRolesAsync(userManager, roleManager);

                task1.Wait();

                var userManager2 = serviceScope.ServiceProvider.GetService<UserManager<User>>();
                var roleManager2 = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                Task task2 = Seed.SeedAdminAsync(userManager2, roleManager2);
                task2.Wait();

            }
        }
    }
}
