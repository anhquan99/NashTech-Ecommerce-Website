using Ecomerece_Web.Data;
using Ecomerece_Web.Services;
using Ecomerece_Web.Services.Implements;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecomerece_Web.Models
{
    public class Seed
    {
        public static void SeedProduct(IRepository<Product> service)
        {
            List<Product> data = new List<Product>
            {
                new Product()
                {
                    productNameID = "Air Jordan 4 Retro 'White Oreo'",
                    releaseDate = Convert.ToDateTime("2021-07-04"),
                    colorWay = "White/Tech Grey/Black/Fire Red",
                    story = "The Air Jordan 4 Retro ‘White Oreo’ features a design theme that recalls the original ‘Oreo’ AJ4 from 1999. The black tumbled leather upper of the older shoe is replaced by a clean white finish, though the speckled molded eyelets in Tech Grey remain the same. The neutral hue is repeated on the Jumpman heel logo and polyurethane midsole, featuring encapsulated Air cushioning in the forefoot and a visible unit under the heel. A second Jumpman adorns the tongue in a contrasting pop of Fire Red.",
                    price = 260,
                    usedPrice = 280,
                    wallpaper = "jordan4-1.jpeg",
                    view = 0,
                    rating = 0,
                    coverImg = "jordan4.jpg",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "Grey"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 4"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "jordan4-1.jpeg" },
                        new Image(){ imageNameID = "jordan4-2.jpeg" },
                        new Image(){ imageNameID = "jordan4-3.jpeg" },
                        new Image(){ imageNameID = "jordan4-5.jpeg" },
                        new Image(){ imageNameID = "jordan4-6.jpeg" },
                        new Image(){ imageNameID = "jordan4-7.jpeg" },
                        new Image(){ imageNameID = "jordan4-8.jpeg" },
                        new Image(){ imageNameID = "jordan4-9.jpeg" },
                        new Image(){ imageNameID = "jordan4-10.jpg" },
                        new Image(){ imageNameID = "jordan4-12.jpg" },
                        new Image(){ imageNameID = "jordan4-13.jpeg" },
                        new Image(){ imageNameID = "jordan4-14.jpeg" }
                    }
                },
                new Product()
                {
                    productNameID = "Air Jordan 3 Retro 'Racer Blue'",
                    releaseDate = Convert.ToDateTime("2021-07-11"),
                    colorWay = "White/Black/Cement Grey/Racer Blue",
                    story = "The Air Jordan 3 Retro ‘Racer Blue’ showcases OG-inspired color blocking that recalls the shoe’s ‘Fire Red’ colorway from 1988. The upper is crafted from white tumbled leather with vibrant royal blue detailing on the sneaker’s eyelets, collar and polyurethane midsole, featuring visible Air sole cushioning under the heel. Additional blue accents land on standard Jumpman branding hits at the tongue and heel. Dual elephant-print overlays are updated with a pronounced crackle pattern.",
                    price = 220,
                    usedPrice = 250,
                    wallpaper = "Air-Jordan-3-Retro-'Racer-Blue'.jpeg",
                    view = 0,
                    rating = 0,
                    coverImg = "Air-Jordan-3-Retro-'Racer-Blue'-1.jpg",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "Blue"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 4"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-1.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-2.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-3.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-4.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-5.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-6.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-7.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-8.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-9.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-10.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-11.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Air Jordan 4 Retro+ 'Oreo' 1999",
                    releaseDate = Convert.ToDateTime("1999-11-02"),
                    colorWay = "Black/Black-Cool Grey",
                    story = "Following the release of two original colorways of the Air Jordan 4, a new Retro+ emerges with premium leather uppers and a few other changes to the classic design. The triangle pieces and window on the side are now leather instead of TPU, a stitched Jumpman replaces the tongue patch, and NIKE AIR is removed on the heel and replaced with a Jumpman. The midsole features paint splatter similar to the White/Cement, and the visible Air unit is still intact.",
                    price = 480,
                    usedPrice = 220,
                    view = 0,
                    rating = 0,
                    coverImg = "Air-Jordan-3-Retro-'Racer-Blue'-1.jpg",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "Grey"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 4"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Air-Jordan-Retro+-'Oreo'-1999-1.png" },
                        new Image(){ imageNameID = "Air-Jordan-Retro+-'Oreo'-1999-2.png" },
                        new Image(){ imageNameID = "Air-Jordan-Retro+-'Oreo'-1999-3.png" },
                        new Image(){ imageNameID = "Air-Jordan-Retro+-'Oreo'-1999-4.png" }
                    }
                },
                new Product()
                {
                    productNameID = "Air Jordan 4 Retro 'Bred' 1999",
                    releaseDate = Convert.ToDateTime("1999-05-06"),
                    colorWay = "Black/Cement Grey",
                    story = "The Air Jordan 4 returns in retro form for the first time since the original release in 1989. This Black and Red color scheme is one of the OG colorways, featuring black nubuck paneling throughout the upper. Cement Grey and Red accents are exactly like the original release, even down to the NIKE AIR on the back heel tab.",
                    price = 449,
                    usedPrice = 325,
                    view = 0,
                    rating = 0,
                    coverImg = "Air-Jordan-4-Retro-'Bred'-1999-1.jpeg",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "Black"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 4"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-1.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-2.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-3.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-4.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-5.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-6.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-7.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-8.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-9.jpeg" }
                    }
                },
                new Product()
                {
                    productNameID = "Yeezy Boost 700 MNVN 'Blue Tint'",
                    releaseDate = Convert.ToDateTime("2021-07-06"),
                    colorWay = "Blue Tint/Blue Tint/Blue Tint",
                    story = "The adidas Yeezy Boost 700 MNVN ‘Blue Tint’ applies an especially vibrant hue to the lightweight polyester upper, secured with no-tie bungee laces and enlivened with reflective accents, including oversized 700 branding on the lateral side panel. Contrasting black hits make their way to the collar lining, tongue and reinforced no-sew overlays at the toe and heel. The seamless build rides on a sculpted black polyurethane midsole, enhanced with full-length drop-in Boost cushioning.",
                    price = 213,
                    usedPrice = 250,
                    view = 0,
                    rating = 0,
                    coverImg = "Yeezy-Boost-700-MNVN-'Blue Tint'-1.jpeg",
                    upperMaterial = "Nylon",
                    brand = new Brand(){ brandNameID = "Adidas"},
                    color = new Color(){ colorNameID = "Blue"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Yeezy Boost 700"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-1.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-2.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-3.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-4.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-5.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-6.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-7.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-8.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-9.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-10.jpeg" }
                    }
                },
                new Product()
                {
                    productNameID = "atmos x LeBron 18 Low 'Sakura'",
                    releaseDate = Convert.ToDateTime("2021-04-24"),
                    colorWay = "Pale Ivory/Light Arctic Pink/Leche Blue",
                    story = "Designed in partnership with the influential Tokyo-based retailer, the atmos x Nike LeBron 18 Low ‘Cherry Blossom’ showcases a spring-ready design, highlighted by a Swoosh formed with pink embroidered florals. The pastel hue is repeated on the sneaker’s molded eyelets and TPU heel counter, as well as a multicolor geometric print that enlivens the textile upper. The low-top sits on a cushy React foam midsole with a large-volume Max Air unit nestled under the heel.",
                    price = 205,
                    usedPrice = 150,
                    view = 0,
                    rating = 0,
                    coverImg = "atmos-x-LeBron 18-Low-'Sakura'-1.jpeg",
                    upperMaterial = "Mesh",
                    brand = new Brand(){ brandNameID = "Nike"},
                    color = new Color(){ colorNameID = "Pink"},
                    category = new Category(){ categoryNameID = "Basketball"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "LeBron 18"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-1.jpeg" },
                        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-2.jpeg" },
                        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-3.jpeg" },
                        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-4.jpeg" },
                        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-5.jpeg" },
                        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-6.jpeg" },
                        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-7.jpeg" },
                        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-8.jpeg" },
                        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-9.jpeg" },
                        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-10.jpeg" },
                    }
                }
            };
            foreach(var i in data)
            {
                if(service.findByID(i.productNameID) == null)
                {
                    service.create(i);
                }
            }
        }
        public async static Task SeedRolesAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));
        }
        public async static Task SeedAdminAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new User
            {
                fullName = "admin",
                UserName = "admin",
                Email = "admin@admin.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                address = "HCM"
            };
            if (userManager.Users.All(u => u.Email != defaultUser.Email))
            {
                await userManager.CreateAsync(defaultUser, "P@assword123");
                await userManager.AddToRoleAsync(defaultUser, Roles.Admin.ToString());
            }
        }
    }
    public enum Roles
    {
        Admin,
        User
    }
}
