using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Interfaces
{
    public interface IUserRepository<T> : IRepository<T>
    {
        public List<T> findAllAdmin();
    }
}
