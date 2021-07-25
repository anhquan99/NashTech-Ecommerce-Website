using Ecomerece_Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Ecomerece_Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AthenticationController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public object Authenticate(String username, String password)
        {
            // My application logic to validate the user
            // returns a user entity with Roles collection
            if (username != "aq" && password != "password") return StatusCode(401);

            var claims = new List<Claim>();
            claims.Add(new Claim("username", username));
            claims.Add(new Claim("displayname", username));

            // Add roles as multiple claims
            claims.Add(new Claim(ClaimTypes.Role, "admin"));
            // Optionally add other app specific claims as needed
            //claims.Add(new Claim("UserState", UserState.ToString()));

            // create a new token with token helper and add our claim
            // from `Westwind.AspNetCore`  NuGet Package
            var token = JwtHelper.GetJwtToken(
                username,
                "e991736ba4e6609f778b7217e1892354b8bdaf28baf7c1add58fcd6764a6ce6f",
                "any",
                "any",
                TimeSpan.FromMinutes(10),
                claims.ToArray());

            return new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expires = token.ValidTo
            };
        }
        [Authorize(Roles = "admin")]
        [HttpGet]
        public String Get()
        {
            return "Admin";
        }
    }
}
