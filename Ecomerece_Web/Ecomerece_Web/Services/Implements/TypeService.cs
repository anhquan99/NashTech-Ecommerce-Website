using Ecomerece_Web.Data;
using Ecomerece_Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Implements
{
    public class TypeService : BaseService<Ecomerece_Web.Data.Type>, IRepository<Ecomerece_Web.Data.Type>
    {
        public TypeService(ApplicationDbContext dbContext) : base(dbContext) { }

        public bool create(Data.Type t)
        {
            throw new NotImplementedException();
        }

        public bool delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Data.Type> findAll()
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

        public Data.Type findByID(string id)
        {
            throw new NotImplementedException();
        }

        public bool update(Data.Type t)
        {
            throw new NotImplementedException();
        }
    }
}
