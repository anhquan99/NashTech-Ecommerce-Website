using Ecomerece_Web.Data;
using Ecomerece_Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Implements
{
    public class ColorService : BaseService<Color>, IRepository<Color>
    {
        public ColorService(ApplicationDbContext dbContext) : base(dbContext) { }

        public bool create(Color t)
        {
            throw new NotImplementedException();
        }

        public bool delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Color> findAll()
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

        public Color findByID(string id)
        {
            throw new NotImplementedException();
        }

        public bool update(Color t)
        {
            throw new NotImplementedException();
        }
    }
}
