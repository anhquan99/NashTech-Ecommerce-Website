using Ecomerece_Web.Data;
using Ecomerece_Web.Services.Implements;
using Ecomerece_Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Implements
{
    public class SilhouetteService : BaseService<Silhouette>, IRepository<Silhouette>
    {
        public SilhouetteService(ApplicationDbContext dbContext) : base(dbContext) { }

        public bool create(Silhouette t)
        {
            throw new NotImplementedException();
        }

        public bool delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Silhouette> findAll()
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

        public Silhouette findByID(string id)
        {
            throw new NotImplementedException();
        }

        public bool update(Silhouette t)
        {
            throw new NotImplementedException();
        }
    }
}
