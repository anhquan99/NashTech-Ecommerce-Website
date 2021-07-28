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
            dbContext.SaveChanges();
            return true;
        }

        public List<User> findAll()
        {
            var roleId = (from p in dbContext.Roles where p.Name == "user" select p).SingleOrDefault();
            var userRoles = dbContext.UserRoles.Where(a => a.RoleId == roleId.Id).ToList();
            List<User> user = new List<User>();
            foreach(var i in userRoles)
            {
                var temp = (from p in dbContext.Users where p.Id == i.UserId select p).SingleOrDefault();
                user.Add(temp);
            }
            //var user = dbContext.Users.Where(a => userRoles.All(i => i.UserId == a.Id)).ToList();
            return user;
        }
        public List<User> findAllAdmin()
        {
            //var roleId = (from p in dbContext.Roles where p.Name == "admin" select p).AsEnumerable();
            //var userRoles = dbContext.UserRoles.Where(a => roleId.All(i => i.Id == a.RoleId)).AsEnumerable();
            //var user = dbContext.Users.Where(a => roleId.All(i => i.Id == a.Id)).ToList();
            var roleId = (from p in dbContext.Roles where p.Name == "admin" select p).SingleOrDefault();
            var userRoles = dbContext.UserRoles.Where(a => a.RoleId == roleId.Id).ToList();
            List<User> user = new List<User>();
            foreach (var i in userRoles)
            {
                var temp = (from p in dbContext.Users where p.Id == i.UserId select p).SingleOrDefault();
                user.Add(temp);
            }
            return user;
        }
        public User findByID(String email)
        {
            return objectSet.Where(p => p.Email == email).SingleOrDefault();
        }

        public bool update(User t)
        {
            var temp = userManager.AddToRoleAsync(t, "admin").Result;
            var temp2 = userManager.RemoveFromRoleAsync(t, "user").Result;
            dbContext.SaveChanges();
            return true;
        }
    }
}
