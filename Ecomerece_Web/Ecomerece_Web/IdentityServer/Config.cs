using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.IdentityServer
{
    public class Config
    {// định nghĩa các Resource gì cho user quản lý 
        // trả về 1 danh sách các identityResource
        public static IEnumerable<IdentityResource> Ids => new IdentityResource[]
        {
            //user quản lý những thứ này 
            // chuẩn của identity ít nhất có 2 thằng này  
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };
        public static IEnumerable<ApiResource> Apis => new ApiResource[]
        {
            new ApiResource("api.aq", "AQ API")
        };
        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("api.aq", "AQ API")
        };
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "aq",
                    ClientSecrets = {new Secret("secret".Sha256())}, // ma hoa theo sha256

                    AllowedGrantTypes = GrantTypes.Code,
                    RequireConsent = false,
                    RequirePkce = true,
                    AllowOfflineAccess = true,
                    AllowedCorsOrigins = {"http://localhost/"},

                    //dang nhap thanh cong thi redirect lai theo duong nay
                    RedirectUris = {"https://localhost:5002/signin-oidc"},

                    //logout chay qua cong nay va su ly logout ben kia
                    PostLogoutRedirectUris = {"https://localhost:5002/signout-callback-oidc"},

                    // client nay cho phep truy capa den nhung thang nay
                    AllowedScopes = new List<String>
                    {
                        //o day chung ta cho truy cap ca thong tin user va api
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.OfflineAccess,
                        "api.aq"
                    }
                },
                new Client
                {
                    ClientId = "swagger",
                    ClientName = "Swaager Client",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    RequireConsent = false,

                    RedirectUris = {"https://localhost:5001/swagger/oauth2-redirect.html"},
                    PostLogoutRedirectUris = {"https://localhost:5001/swagger/oauth2-redirect.html"},
                    AllowedCorsOrigins = {"https://localhost:5001"},

                    AllowedScopes = new List<String>
                    {
                        //o day chung ta cho truy cap ca thong tin user va api
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.OfflineAccess,
                        "api.aq"
                    }

                }
            };
    }
}
