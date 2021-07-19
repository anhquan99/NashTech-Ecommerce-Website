using Ecomerece_Web.Data;
using Ecomerece_Web.Services.Implements;
using Ecomerece_Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Implements
{
    public class BrandService : BaseService<Brand>, IRepository<Brand>
    {
        public BrandService(ApplicationDbContext dbContext) : base(dbContext) { }
        public bool create(Brand t)
        {
            throw new NotImplementedException();
        }

        public bool delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> findAll()
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

        public Brand findByID(string id)
        {
            throw new NotImplementedException();
        }

        public bool update(Brand t)
        {
            throw new NotImplementedException();
        }
    }
}
