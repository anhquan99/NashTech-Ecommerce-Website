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
        public DbSet<Brand> brands { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Color> colors { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Silhouette> silhouettes { get; set; }
        public DbSet<Type> types { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Image> images { get; set; }
    }
}
