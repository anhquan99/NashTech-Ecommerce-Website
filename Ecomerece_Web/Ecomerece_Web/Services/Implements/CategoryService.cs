using Ecomerece_Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Ecomerece_Web.Services.Interfaces;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Implements
{
    public class CategoryService : BaseService<Category>, IRepository<Category>
    {
        public CategoryService(ApplicationDbContext dbContext) : base(dbContext) { }

        public bool create(Category t)
        {
            throw new NotImplementedException();
        }

        public bool delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Category> findAll()
        {
            try
            {
                return objectSet.ToList();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }
        }

        public Category findByID(string id)
        {
            throw new NotImplementedException();
        }

        public bool update(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
