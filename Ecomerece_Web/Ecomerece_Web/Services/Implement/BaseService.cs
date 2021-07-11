using Ecomerece_Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Implement
{
    public class BaseService<T> where T : class
    {
        protected readonly ApplicationDbContext dbContext;
        protected DbSet<T> objectSet;
        public BaseService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.objectSet = dbContext.Set<T>();
        }
    }
}
