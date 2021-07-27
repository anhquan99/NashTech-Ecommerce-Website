using Ecomerece_Web.Data;
using Ecomerece_Web.Data.Prototype;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Services.Adapter
{
    public class UserAdapter : IAdapter<User, UserPrototype>
    {
        private readonly UserManager<User> userManager;
        public UserAdapter(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        public UserPrototype convertFromOriginToProtoType(User original)
        {
            var userRole = userManager.GetRolesAsync(original).Result.FirstOrDefault();
            return new UserPrototype
            {
                email = original.Email,
                address = original.address,
                fullName = original.fullName,
                role = userRole
            };
        }

        public User convertFromProtoTypeToOriginal(UserPrototype prototype)
        {
            return new User
            {
                Email = prototype.email,
                address = prototype.address,
                fullName = prototype.fullName,
            };
        }
    }
}
