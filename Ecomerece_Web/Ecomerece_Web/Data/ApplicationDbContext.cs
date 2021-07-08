using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecomerece_Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        DbSet<Brand> brands { get; set; }
        DbSet<Category> categories { get; set; }
        DbSet<Color> colors { get; set; }
        DbSet<Product> products { get; set; }
        DbSet<Silhouette> silhouettes { get; set; } 
        DbSet<Type> types { get; set; }
        DbSet<User> users { get; set; }
        DbSet<Image> images { get; set; }
    }
}
