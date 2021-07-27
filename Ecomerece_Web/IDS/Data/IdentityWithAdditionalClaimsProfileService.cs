using IdentityModel;
using IdentityServer4;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IDS.Data
{
    //https://github.com/damienbod/AspNet5IdentityServerAngularImplicitFlow/blob/main/src/StsServerIdentity/Startup.cs
    //https://damienbod.com/2016/11/18/extending-identity-in-identityserver4-to-manage-users-in-asp-net-core/
    public class IdentityWithAdditionalClaimsProfileService : IProfileService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserClaimsPrincipalFactory<IdentityUser> _claimsFactory;

        public IdentityWithAdditionalClaimsProfileService(UserManager<IdentityUser> userManager, IUserClaimsPrincipalFactory<IdentityUser> claimsFactory)
        {
            _userManager = userManager;
            _claimsFactory = claimsFactory;
        }
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var sub = context.Subject.GetSubjectId();

            var user = await _userManager.FindByIdAsync(sub);
            var principal = await _claimsFactory.CreateAsync(user);

            var claims = principal.Claims.ToList();
            claims = claims.Where(claim => context.RequestedClaimTypes.Contains(claim.Type)).ToList();
            claims.Add(new Claim(JwtClaimTypes.GivenName, user.UserName));

            claims.Add(new Claim(JwtClaimTypes.Role, "admin"));

            claims.Add(new Claim(IdentityServerConstants.StandardScopes.Email, user.Email));

            context.IssuedClaims = claims;
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var sub = context.Subject.GetSubjectId();
            var user = await _userManager.FindByIdAsync(sub);
            context.IsActive = user != null;
        }
    }
}
