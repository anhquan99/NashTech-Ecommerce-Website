using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services
{
    interface IRepository<T>
    {
        public List<T> findAll();
        public bool update(T t);
        public bool delete(String id);
        public bool create(T t);
        public T findByID(String id);

    }
}
