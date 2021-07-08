using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Data
{
    public class User : IdentityUser
    {
        [Required]
        public String fullName { get; set; }
    }
}
