using Ecomerece_Web.Data;
using Ecomerece_Web.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Implements
{
    public class UserService : BaseService<User>, IUserRepository<User>
    {
        private readonly UserManager<User> userManager;
        public UserService(ApplicationDbContext dbContext, UserManager<User> userManager) : base(dbContext)
        {
            this.userManager = userManager;
        }

        public bool create(User t)
        {
            throw new NotImplementedException();
        }

        public bool delete(string email)
        {
            var deleteUser = objectSet.Where(p => p.Email == email).SingleOrDefault();
            this.objectSet.Remove(deleteUser);
            return true;
        }

        public List<User> findAll()
        {
            return dbContext.Users.Where(p => p == dbContext.UserRoles.Where(i => i == dbContext.Roles.Where(x => x.Name == "user"))).ToList();
        }
        public List<User> findAllAdmin()
        {
            return dbContext.Users.Where(p => p == dbContext.UserRoles.Where(i => i == dbContext.Roles.Where(x => x.Name == "admin"))).ToList();
        }
        public User findByID(String email)
        {
            return objectSet.Where(p => p.Email == email).SingleOrDefault();
        }

        public bool update(User t)
        {
            userManager.AddToRoleAsync(t, "admin");
            return true;
        }
    }
}
