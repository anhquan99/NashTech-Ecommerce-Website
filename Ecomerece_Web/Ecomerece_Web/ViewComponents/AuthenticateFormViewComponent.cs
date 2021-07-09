using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.ViewComponents
{
    public class AuthenticateFormViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(bool direction)
        {
            if (direction)
            {
                return View("LoginForm");
            }
            else if (!direction)
            {
                return View("RegisterForm");
            }
            else throw new Exception("VIEW COMPONENT NOT FOUND");
        }
    }
}
