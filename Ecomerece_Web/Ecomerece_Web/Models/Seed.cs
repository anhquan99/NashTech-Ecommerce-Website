using Ecomerece_Web.Data;
using Ecomerece_Web.Services;
using Ecomerece_Web.Services.Implements;
using Ecomerece_Web.Services.Interfaces;
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
                #region passed seed
                //new Product()
                //{
                //    productNameID = "Air Jordan 4 Retro 'White Oreo'",
                //    releaseDate = Convert.ToDateTime("2021-07-04"),
                //    colorWay = "White/Tech Grey/Black/Fire Red",
                //    story = "The Air Jordan 4 Retro ‘White Oreo’ features a design theme that recalls the original ‘Oreo’ AJ4 from 1999. The black tumbled leather upper of the older shoe is replaced by a clean white finish, though the speckled molded eyelets in Tech Grey remain the same. The neutral hue is repeated on the Jumpman heel logo and polyurethane midsole, featuring encapsulated Air cushioning in the forefoot and a visible unit under the heel. A second Jumpman adorns the tongue in a contrasting pop of Fire Red.",
                //    price = 260,
                //    usedPrice = 280,
                //    wallpaper = "jordan4-1.jpeg",
                //    view = 0,
                //    rating = 0,
                //    coverImg = "jordan4.jpg",
                //    brand = new Brand(){ brandNameID = "Jordan"},
                //    color = new Color(){ colorNameID = "Grey"},
                //    category = new Category(){ categoryNameID = "Lifestyle"},
                //    type = new Data.Type(){typeNameID = "Sneaker"},
                //    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 4"},
                //    images = new List<Image>()
                //    {
                //        new Image(){ imageNameID = "jordan4-1.jpeg" },
                //        new Image(){ imageNameID = "jordan4-2.jpeg" },
                //        new Image(){ imageNameID = "jordan4-3.jpeg" },
                //        new Image(){ imageNameID = "jordan4-5.jpeg" },
                //        new Image(){ imageNameID = "jordan4-6.jpeg" },
                //        new Image(){ imageNameID = "jordan4-7.jpeg" },
                //        new Image(){ imageNameID = "jordan4-8.jpeg" },
                //        new Image(){ imageNameID = "jordan4-9.jpeg" },
                //        new Image(){ imageNameID = "jordan4-10.jpg" },
                //        new Image(){ imageNameID = "jordan4-12.jpg" },
                //        new Image(){ imageNameID = "jordan4-13.jpeg" },
                //        new Image(){ imageNameID = "jordan4-14.jpeg" }
                //    }
                //},
                //new Product()
                //{
                //    productNameID = "Air Jordan 3 Retro 'Racer Blue'",
                //    releaseDate = Convert.ToDateTime("2021-07-11"),
                //    colorWay = "White/Black/Cement Grey/Racer Blue",
                //    story = "The Air Jordan 3 Retro ‘Racer Blue’ showcases OG-inspired color blocking that recalls the shoe’s ‘Fire Red’ colorway from 1988. The upper is crafted from white tumbled leather with vibrant royal blue detailing on the sneaker’s eyelets, collar and polyurethane midsole, featuring visible Air sole cushioning under the heel. Additional blue accents land on standard Jumpman branding hits at the tongue and heel. Dual elephant-print overlays are updated with a pronounced crackle pattern.",
                //    price = 220,
                //    usedPrice = 250,
                //    wallpaper = "Air-Jordan-3-Retro-'Racer-Blue'.jpeg",
                //    view = 0,
                //    rating = 0,
                //    coverImg = "Air-Jordan-3-Retro-'Racer-Blue'-1.jpg",
                //    brand = new Brand(){ brandNameID = "Jordan"},
                //    color = new Color(){ colorNameID = "Blue"},
                //    category = new Category(){ categoryNameID = "Lifestyle"},
                //    type = new Data.Type(){typeNameID = "Sneaker"},
                //    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 4"},
                //    images = new List<Image>()
                //    {
                //        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-1.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-2.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-3.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-4.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-5.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-6.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-7.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-8.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-9.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-10.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-3-Retro-'Racer-Blue'-11.jpeg" },
                //    }
                //},
                //new Product()
                //{
                //    productNameID = "Air Jordan 4 Retro+ 'Oreo' 1999",
                //    releaseDate = Convert.ToDateTime("1999-11-02"),
                //    colorWay = "Black/Black-Cool Grey",
                //    story = "Following the release of two original colorways of the Air Jordan 4, a new Retro+ emerges with premium leather uppers and a few other changes to the classic design. The triangle pieces and window on the side are now leather instead of TPU, a stitched Jumpman replaces the tongue patch, and NIKE AIR is removed on the heel and replaced with a Jumpman. The midsole features paint splatter similar to the White/Cement, and the visible Air unit is still intact.",
                //    price = 480,
                //    usedPrice = 220,
                //    view = 0,
                //    rating = 0,
                //    coverImg = "Air-Jordan-3-Retro-'Racer-Blue'-1.jpg",
                //    brand = new Brand(){ brandNameID = "Jordan"},
                //    color = new Color(){ colorNameID = "Grey"},
                //    category = new Category(){ categoryNameID = "Lifestyle"},
                //    type = new Data.Type(){typeNameID = "Sneaker"},
                //    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 4"},
                //    images = new List<Image>()
                //    {
                //        new Image(){ imageNameID = "Air-Jordan-Retro+-'Oreo'-1999-1.png" },
                //        new Image(){ imageNameID = "Air-Jordan-Retro+-'Oreo'-1999-2.png" },
                //        new Image(){ imageNameID = "Air-Jordan-Retro+-'Oreo'-1999-3.png" },
                //        new Image(){ imageNameID = "Air-Jordan-Retro+-'Oreo'-1999-4.png" }
                //    }
                //},
                //new Product()
                //{
                //    productNameID = "Air Jordan 4 Retro 'Bred' 1999",
                //    releaseDate = Convert.ToDateTime("1999-05-06"),
                //    colorWay = "Black/Cement Grey",
                //    story = "The Air Jordan 4 returns in retro form for the first time since the original release in 1989. This Black and Red color scheme is one of the OG colorways, featuring black nubuck paneling throughout the upper. Cement Grey and Red accents are exactly like the original release, even down to the NIKE AIR on the back heel tab.",
                //    price = 449,
                //    usedPrice = 325,
                //    view = 0,
                //    rating = 0,
                //    coverImg = "Air-Jordan-4-Retro-'Bred'-1999-1.jpeg",
                //    brand = new Brand(){ brandNameID = "Jordan"},
                //    color = new Color(){ colorNameID = "Black"},
                //    category = new Category(){ categoryNameID = "Lifestyle"},
                //    type = new Data.Type(){typeNameID = "Sneaker"},
                //    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 4"},
                //    images = new List<Image>()
                //    {
                //        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-1.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-2.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-3.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-4.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-5.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-6.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-7.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-8.jpeg" },
                //        new Image(){ imageNameID = "Air-Jordan-4-Retro-'Bred'-1999-9.jpeg" }
                //    }
                //},
                //new Product()
                //{
                //    productNameID = "Yeezy Boost 700 MNVN 'Blue Tint'",
                //    releaseDate = Convert.ToDateTime("2021-07-06"),
                //    colorWay = "Blue Tint/Blue Tint/Blue Tint",
                //    story = "The adidas Yeezy Boost 700 MNVN ‘Blue Tint’ applies an especially vibrant hue to the lightweight polyester upper, secured with no-tie bungee laces and enlivened with reflective accents, including oversized 700 branding on the lateral side panel. Contrasting black hits make their way to the collar lining, tongue and reinforced no-sew overlays at the toe and heel. The seamless build rides on a sculpted black polyurethane midsole, enhanced with full-length drop-in Boost cushioning.",
                //    price = 213,
                //    usedPrice = 250,
                //    view = 0,
                //    rating = 0,
                //    coverImg = "Yeezy-Boost-700-MNVN-'Blue Tint'-1.jpeg",
                //    upperMaterial = "Nylon",
                //    brand = new Brand(){ brandNameID = "Adidas"},
                //    color = new Color(){ colorNameID = "Blue"},
                //    category = new Category(){ categoryNameID = "Lifestyle"},
                //    type = new Data.Type(){typeNameID = "Sneaker"},
                //    silhouette = new Silhouette{silhouetteNameID = "Yeezy Boost 700"},
                //    images = new List<Image>()
                //    {
                //        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-1.jpeg" },
                //        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-2.jpeg" },
                //        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-3.jpeg" },
                //        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-4.jpeg" },
                //        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-5.jpeg" },
                //        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-6.jpeg" },
                //        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-7.jpeg" },
                //        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-8.jpeg" },
                //        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-9.jpeg" },
                //        new Image(){ imageNameID = "Yeezy-Boost-700-MNVN-'Blue Tint'-10.jpeg" }
                //    }
                //},
                //new Product()
                //{
                //    productNameID = "atmos x LeBron 18 Low 'Sakura'",
                //    releaseDate = Convert.ToDateTime("2021-04-24"),
                //    colorWay = "Pale Ivory/Light Arctic Pink/Leche Blue",
                //    story = "Designed in partnership with the influential Tokyo-based retailer, the atmos x Nike LeBron 18 Low ‘Cherry Blossom’ showcases a spring-ready design, highlighted by a Swoosh formed with pink embroidered florals. The pastel hue is repeated on the sneaker’s molded eyelets and TPU heel counter, as well as a multicolor geometric print that enlivens the textile upper. The low-top sits on a cushy React foam midsole with a large-volume Max Air unit nestled under the heel.",
                //    price = 205,
                //    usedPrice = 150,
                //    view = 0,
                //    rating = 0,
                //    coverImg = "atmos-x-LeBron 18-Low-'Sakura'-1.jpeg",
                //    upperMaterial = "Mesh",
                //    brand = new Brand(){ brandNameID = "Nike"},
                //    color = new Color(){ colorNameID = "Pink"},
                //    category = new Category(){ categoryNameID = "Basketball"},
                //    type = new Data.Type(){typeNameID = "Sneaker"},
                //    silhouette = new Silhouette{silhouetteNameID = "LeBron 18"},
                //    images = new List<Image>()
                //    {
                //        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-1.jpeg" },
                //        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-2.jpeg" },
                //        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-3.jpeg" },
                //        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-4.jpeg" },
                //        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-5.jpeg" },
                //        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-6.jpeg" },
                //        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-7.jpeg" },
                //        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-8.jpeg" },
                //        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-9.jpeg" },
                //        new Image(){ imageNameID = "atmos-x-LeBron 18-Low-'Sakura'-10.jpeg" },
                //    }
                //},
                #endregion
                #region new seed
                new Product()
                {
                    productNameID = "Air Jordan 1 Retro High OG 'Electro Orange'",
                    releaseDate = Convert.ToDateTime("2021-07-18"),
                    colorWay = "White/Electro Orange/Black",
                    story = "The Air Jordan 1 Retro High OG ‘Electro Orange’ showcases a familiar palette that recalls the coveted ‘Shattered Backboard’ colorway from 2015. The upper is crafted from white leather, with contrasting black hits on the eyestay, Swoosh and forefoot overlay. A vibrant orange finish is applied to the padded collar and rubber outsole, featuring a grippy traction pattern carried over from the original 1985 release. An additional pop of orange makes its way to the Nike Air tag atop the nylon tongue.",
                    price = 225,
                    usedPrice = 200,
                    view = 0,
                    rating = 0,
                    coverImg = "Air Jordan-1-Retro-High-OG-'Electro-Orange'-1.jpeg",
                    upperMaterial = "Leather",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "Orange"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 1"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Air Jordan-1-Retro-High-OG-'Electro-Orange'-1.jpeg" },
                        new Image(){ imageNameID = "Air Jordan-1-Retro-High-OG-'Electro-Orange'-2.jpeg" },
                        new Image(){ imageNameID = "Air Jordan-1-Retro-High-OG-'Electro-Orange'-3.jpeg" },
                        new Image(){ imageNameID = "Air Jordan-1-Retro-High-OG-'Electro-Orange'-4.jpeg" },
                        new Image(){ imageNameID = "Air Jordan-1-Retro-High-OG-'Electro-Orange'-5.jpeg" },
                        new Image(){ imageNameID = "Air Jordan-1-Retro-High-OG-'Electro-Orange'-6.jpeg" },
                        new Image(){ imageNameID = "Air Jordan-1-Retro-High-OG-'Electro-Orange'-7.jpeg" },
                        new Image(){ imageNameID = "Air Jordan-1-Retro-High-OG-'Electro-Orange'-8.jpeg" },
                        new Image(){ imageNameID = "Air Jordan-1-Retro-High-OG-'Electro-Orange'-9.jpeg" },
                        new Image(){ imageNameID = "Air Jordan-1-Retro-High-OG-'Electro-Orange'-10.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Air Jordan 1 Mid 'Black Gym Red'",
                    releaseDate = Convert.ToDateTime("2021-05-25"),
                    colorWay = "White/Gym Red/Black",
                    story = "The Air Jordan 1 Mid ‘Black Gym Red’ steps out in a familiar color scheme that honors the Jordan franchise’s Chicago roots. The sneaker’s white leather upper is contrasted by black overlays and a crimson Nike Swoosh. Additional hits of Gym Red land on the padded collar and rubber outsole, as well as the Jumpman logo on the woven tongue tag and a retro Wings logo debossed on the lateral ankle. Standard Air Jordan 1 design features remain intact, including variable width lacing, a perforated toe box and breathable nylon tongue.",
                    price = 225,
                    usedPrice = 200,
                    view = 0,
                    rating = 0,
                    coverImg = "Air-Jordan-1-Mid-'Black-Gym-Red'-1.jpeg",
                    upperMaterial = "Leather",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "White"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 1"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Black-Gym-Red'-1.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Black-Gym-Red'-2.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Black-Gym-Red'-3.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Black-Gym-Red'-4.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Black-Gym-Red'-5.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Black-Gym-Red'-6.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Black-Gym-Red'-7.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Black-Gym-Red'-8.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Air Jordan 1 Mid 'Tropical Twist'",
                    releaseDate = Convert.ToDateTime("2021-06-23"),
                    colorWay = "White/Black/Tropical Twist",
                    story = "The Air Jordan 1 Mid ‘Tropical Twist’ injects a vibrant burst of color to a classic silhouette modeled after Peter Moore’s original high-top from 1985. The all-leather upper features a crisp white base with a contrasting black forefoot overlay and bright teal accents on the Swoosh, eyestay, heel overlay and collar flap, imprinted with a black Wings logo on the lateral side. Jumpman branding decorates the woven tongue tag. The mid-top rides on a rubber cupsole with encapsulated Nike Air cushioning in the heel.",
                    price = 110,
                    usedPrice = 117,
                    view = 0,
                    rating = 0,
                    coverImg = "Air-Jordan-1-Mid-'Tropical-Twist'-1.jpeg",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "Green"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 1"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Tropical-Twist'-1.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Tropical-Twist'-2.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Tropical-Twist'-3.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Tropical-Twist'-4.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Tropical-Twist'-5.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Tropical-Twist'-6.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Tropical-Twist'-7.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Mid-'Tropical-Twist'-8.jpeg" },

                    }
                },
                new Product()
                {
                    productNameID = "Air Jordan 4 Retro SE 'Sashiko'",
                    releaseDate = Convert.ToDateTime("2020-12-06"),
                    colorWay = "Deep Ocean/Sail/Cement Grey/Fire Red",
                    story = "The Air Jordan 4 Retro SE ‘Sashiko’ gives the iconic silhouette a textile makeover that replaces traditional leather construction. The paneled upper is treated to varying abstract prints for a patchwork-like effect, complete with decorative embroidery that gives the nod to Japanese Sashiko stitching — a traditional technique originally used to reinforce or repair garments for long-lasting wear. A two-tone palette of Deep Ocean and Sail is disrupted by Fire Red accents atop the tongue and within the visible Air sole unit.",
                    price = 231,
                    usedPrice = 245,
                    view = 0,
                    rating = 0,
                    coverImg = "Air-Jordan-4-Retro-SE-'Sashiko'-1.jpeg",
                    upperMaterial = "Demin",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "Blue"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 4"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-SE-'Sashiko'-1.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-SE-'Sashiko'-2.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-SE-'Sashiko'-3.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-SE-'Sashiko'-4.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-SE-'Sashiko'-5.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-SE-'Sashiko'-6.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-SE-'Sashiko'-7.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-4-Retro-SE-'Sashiko'-8.jpeg" },

                    }
                }, 
                new Product()
                {
                    productNameID = "Air Jordan 1 Retro High OG GS 'Shadow 2.0'",
                    releaseDate = Convert.ToDateTime("2021-05-16"),
                    colorWay = "Black/Light Smoke Grey/White",
                    story = "Crafted for big kids, the Air Jordan 1 Retro High OG GS ‘Shadow 2.0’ showcases a neutral palette reminiscent of the original Air Jordan 1 ‘Shadow’ from 1985. The high-top makes use of a black leather upper with light grey overlays and a matching grey Swoosh. Nike Air branding decorates the leather tongue tag, while the classic Wings logo is stamped on the lateral collar flap. Underfoot, the black rubber outsole features a grippy traction pattern made for pivoting.",
                    price = 170,
                    usedPrice = 250,
                    view = 0,
                    rating = 0,
                    coverImg = "Air-Jordan-1-Retro-High-OG-GS-'Shadow 2.0'-1.jpeg",
                    upperMaterial = "Suede",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "Grey"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 1"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Air-Jordan-1-Retro-High-OG-GS-'Shadow 2.0'-1.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Retro-High-OG-GS-'Shadow 2.0'-2.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Retro-High-OG-GS-'Shadow 2.0'-3.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Retro-High-OG-GS-'Shadow 2.0'-4.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Retro-High-OG-GS-'Shadow 2.0'-5.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Retro-High-OG-GS-'Shadow 2.0'-6.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Retro-High-OG-GS-'Shadow 2.0'-7.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-1-Retro-High-OG-GS-'Shadow 2.0'-8.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Air Jordan 13 Retro Low GS 'Very Berry'",
                    releaseDate = Convert.ToDateTime("2021-07-09"),
                    colorWay = "Black/Very Berry/White",
                    story = "The Air Jordan 13 Retro Low GS ‘Very Berry’ delivers Tinker Hatfield’s 1997 design in a two-tone colorway made exclusively for kids. The upper combines a black leather toe with matching black synthetic suede at the midfoot and heel. Stitched leather overlays are rendered in a bold crimson finish. Jumpman branding lands on the tongue and lateral collar in the same red hue. The low-top is mounted on a Phylon midsole, supported underfoot by the 13’s signature panther-paw outsole.",
                    price = 140,
                    usedPrice = 130,
                    view = 0,
                    rating = 0,
                    coverImg = "Air-Jordan-13-Retro-Low-GS-'Very-Berry'-1.jpeg",
                    upperMaterial = "Leather",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "Red"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 13"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Air-Jordan-13-Retro-Low-GS-'Very-Berry'-1.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-13-Retro-Low-GS-'Very-Berry'-2.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-13-Retro-Low-GS-'Very-Berry'-3.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-13-Retro-Low-GS-'Very-Berry'-4.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-13-Retro-Low-GS-'Very-Berry'-5.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-13-Retro-Low-GS-'Very-Berry'-6.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-13-Retro-Low-GS-'Very-Berry'-7.jpeg" },
                        new Image(){ imageNameID = "Air-Jordan-13-Retro-Low-GS-'Very-Berry'-8.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Dunk High 'Kentucky' 2021",
                    releaseDate = Convert.ToDateTime("2021-06-12"),
                    colorWay = "White/Game Royal/Total Orange",
                    story = "Recalling the 1985 Be True to Your School 'Kentucky' colorway, the Dunk High 'Kentucky' released in June 2021. Built entirely with leather, the shoe's upper appears in a mix of white and Game Royal, with perforations on the toe box providing breathability. A nylon tongue is included for further breathability, while underfoot, the two-tone look continues onto the tooling, which includes an outsole with a concentric traction pattern.",
                    price = 159,
                    usedPrice = 170,
                    view = 0,
                    rating = 0,
                    coverImg = "Dunk-High-'Kentucky'-2021-1.jpeg",
                    upperMaterial = "Leather",
                    brand = new Brand(){ brandNameID = "Nike"},
                    color = new Color(){ colorNameID = "Blue"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Dunk"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Dunk-High-'Kentucky'-2021-1.jpeg" },
                        new Image(){ imageNameID = "Dunk-High-'Kentucky'-2021-2.jpeg" },
                        new Image(){ imageNameID = "Dunk-High-'Kentucky'-2021-3.jpeg" },
                        new Image(){ imageNameID = "Dunk-High-'Kentucky'-2021-4.jpeg" },
                        new Image(){ imageNameID = "Dunk-High-'Kentucky'-2021-5.jpeg" },
                        new Image(){ imageNameID = "Dunk-High-'Kentucky'-2021-6.jpeg" },
                        new Image(){ imageNameID = "Dunk-High-'Kentucky'-2021-7.jpeg" },
                        new Image(){ imageNameID = "Dunk-High-'Kentucky'-2021-8.jpeg" },
                    }
                }, 
                new Product()
                {
                    productNameID = "Fragment Design x Dunk High 'Beijing'",
                    releaseDate = Convert.ToDateTime("2021-06-06"),
                    colorWay = "Wine/Black/White",
                    story = "Taken from a larger City Pack, the Fragment Design x Nike Dunk High ‘Beijing’ presents a refreshed take on the creative partners’ original Dunk High collaboration from 2010. The materials and color palette remain mostly unchanged, but the mismatched design of the original is discarded in favor of traditional color blocking. The high-top carries a leather upper that combines a purple base with contrasting black overlays and a matching black Swoosh. Fragment’s signature lighting bolt logo is stamped on the lateral heel, while fine-print branding is inscribed on the white rubber midsole.",
                    price = 130,
                    usedPrice = 175,
                    view = 0,
                    rating = 0,
                    coverImg = "Fragment-Design-x-Dunk-High-'Beijing'-1.jpeg",
                    upperMaterial = "Leather",
                    brand = new Brand(){ brandNameID = "Nike"},
                    color = new Color(){ colorNameID = "Purple"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Dunk"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Fragment-Design-x-Dunk-High-'Beijing'-1.jpeg" },
                        new Image(){ imageNameID = "Fragment-Design-x-Dunk-High-'Beijing'-2.jpeg" },
                        new Image(){ imageNameID = "Fragment-Design-x-Dunk-High-'Beijing'-3.jpeg" },
                        new Image(){ imageNameID = "Fragment-Design-x-Dunk-High-'Beijing'-4.jpeg" },
                        new Image(){ imageNameID = "Fragment-Design-x-Dunk-High-'Beijing'-5.jpeg" },
                        new Image(){ imageNameID = "Fragment-Design-x-Dunk-High-'Beijing'-6.jpeg" },
                        new Image(){ imageNameID = "Fragment-Design-x-Dunk-High-'Beijing'-7.jpeg" },
                        new Image(){ imageNameID = "Fragment-Design-x-Dunk-High-'Beijing'-8.jpeg" },
                        new Image(){ imageNameID = "Fragment-Design-x-Dunk-High-'Beijing'-9.jpeg" },
                        new Image(){ imageNameID = "Fragment-Design-x-Dunk-High-'Beijing'-10.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Golf Le Fleur x Chuck 70 High 'Flame - Pastel Yellow'",
                    releaseDate = Convert.ToDateTime("2021-05-12"),
                    colorWay = "Pastel Yellow/Almond Blossom",
                    story = "",
                    price = 144,
                    usedPrice = 132,
                    view = 0,
                    rating = 0,
                    coverImg = "Golf-Le-Fleur-x-Chuck-70-High-'Flame-Pastel-Yellow'-1.jpeg",
                    upperMaterial = "Textile",
                    brand = new Brand(){ brandNameID = "Converse"},
                    color = new Color(){ colorNameID = "Yellow"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Chuck 70"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Golf-Le-Fleur-x-Chuck-70-High-'Flame-Pastel-Yellow'-1.jpeg" },
                        new Image(){ imageNameID = "Golf-Le-Fleur-x-Chuck-70-High-'Flame-Pastel-Yellow'-2.jpeg" },
                        new Image(){ imageNameID = "Golf-Le-Fleur-x-Chuck-70-High-'Flame-Pastel-Yellow'-3.jpeg" },
                        new Image(){ imageNameID = "Golf-Le-Fleur-x-Chuck-70-High-'Flame-Pastel-Yellow'-4.jpeg" },
                        new Image(){ imageNameID = "Golf-Le-Fleur-x-Chuck-70-High-'Flame-Pastel-Yellow'-5.jpeg" },
                        new Image(){ imageNameID = "Golf-Le-Fleur-x-Chuck-70-High-'Flame-Pastel-Yellow'-6.jpeg" },
                        new Image(){ imageNameID = "Golf-Le-Fleur-x-Chuck-70-High-'Flame-Pastel-Yellow'-7.jpeg" },
                        new Image(){ imageNameID = "Golf-Le-Fleur-x-Chuck-70-High-'Flame-Pastel-Yellow'-8.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "LeBron 8 Retro 'South Beach' 2021",
                    releaseDate = Convert.ToDateTime("2021-07-22"),
                    colorWay = "Retro/Pink Flash/Filament Green/Black",
                    story = "The 2021 reissue of the Nike LeBron 8 Retro ‘South Beach’ brings back for the first time a supremely coveted colorway from LeBron James’ signature line. Originally released in 2010 to coincide with the athlete’s move to Miami, the mid-top packs a bevy of performance elements to go along with the uniquely evocative color scheme. A bright teal finish is applied to the upper, constructed from genuine leather with Flywire-infused TPU panels. Pink laces are complemented by color-matched accents on the molded tongue, featuring James’ embossed lion logo. The sneaker is mounted on a Phylon midsole with a green-tinged 360-degree Max Air unit.",
                    price = 268,
                    usedPrice = 250,
                    view = 0,
                    rating = 0,
                    coverImg = "LeBron-8-Retro-'South-Beach'-2021-1.jpeg",
                    upperMaterial = "Leather",
                    brand = new Brand(){ brandNameID = "Nike"},
                    color = new Color(){ colorNameID = "Teal"},
                    category = new Category(){ categoryNameID = "Basketball"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Max LeBron 8"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "LeBron-8-Retro-'South-Beach'-2021-1.jpeg" },
                        new Image(){ imageNameID = "LeBron-8-Retro-'South-Beach'-2021-2.jpeg" },
                        new Image(){ imageNameID = "LeBron-8-Retro-'South-Beach'-2021-3.jpeg" },
                        new Image(){ imageNameID = "LeBron-8-Retro-'South-Beach'-2021-4.jpeg" },
                        new Image(){ imageNameID = "LeBron-8-Retro-'South-Beach'-2021-5.jpeg" },
                        new Image(){ imageNameID = "LeBron-8-Retro-'South-Beach'-2021-6.jpeg" },
                        new Image(){ imageNameID = "LeBron-8-Retro-'South-Beach'-2021-7.jpeg" },
                        new Image(){ imageNameID = "LeBron-8-Retro-'South-Beach'-2021-8.jpeg" },
                        new Image(){ imageNameID = "LeBron-8-Retro-'South-Beach'-2021-9.jpeg" },
                        new Image(){ imageNameID = "LeBron-8-Retro-'South-Beach'-2021-10.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Travis Scott x Air Jordan 6 Retro 'British Khaki'",
                    releaseDate = Convert.ToDateTime("2021-05-01"),
                    colorWay = "British Khaki/Sail/Bright Crimson",
                    story = "Following on the heels of the coveted ‘Olive’ colorway from 2019, the Travis Scott x Air Jordan 6 Retro ‘British Khaki’ reunites Jordan Brand with the Houston rapper. The upper is crafted with suede and canvas, accented with Bright Crimson details. The stash pouch makes a repeat appearance on the lateral collar, while new zippered detailing is added to the medial side. Mismatched Nike Air and Cactus Jack branding adorns the heel of the left and right shoe, with additional graphics on the midsole, outsole, tongue and lace lock.",
                    price = 324,
                    usedPrice = 400,
                    view = 0,
                    rating = 0,
                    coverImg = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-1.jpeg",
                    upperMaterial = "Leather",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "Tan"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 6"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-1.jpeg" },
                        new Image(){ imageNameID = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-2.jpeg" },
                        new Image(){ imageNameID = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-3.jpeg" },
                        new Image(){ imageNameID = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-4.jpeg" },
                        new Image(){ imageNameID = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-5.jpeg" },
                        new Image(){ imageNameID = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-6.jpeg" },
                        new Image(){ imageNameID = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-7.jpeg" },
                        new Image(){ imageNameID = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-8.jpeg" },
                        new Image(){ imageNameID = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-9.jpeg" },
                        new Image(){ imageNameID = "Travis-Scott-x-Air-Jordan-6-Retro-'British-Khaki'-10.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Union LA x Air Jordan 4 Retro 'Desert Moss'",
                    releaseDate = Convert.ToDateTime("2021-06-21"),
                    colorWay = "Desert Moss/Turquoise Blue/Dark Iris",
                    story = "Releasing as part of the renowned retailer’s 30th anniversary festivities, the Union LA x Air Jordan 4 Retro ‘Desert Moss’ brings back the creative partners’ modified AJ4 from 2020. This pair is taken from a capsule dubbed ‘Tent and Trail,’ featuring colors and materials inspired by outdoor gear from the ‘80s and ‘90s. The mid-top carries an upper built with a blend of bright purple mesh and mustard yellow suede. Vibrant pops of turquoise land on the lower molded eyelets and heel tab, marked with Nike Air branding in a lavender hue. A stitched fold-down tongue, yellow ‘UN/LA’ tag and translucent TPU wings are carried over from the 2020 release. The sneaker is mounted on an off-white polyurethane midsole with an aqua-tinged Air-sole unit under the heel.",
                    price = 379,
                    usedPrice = 400,
                    view = 0,
                    rating = 0,
                    coverImg = "Union-LA-x-Air-Jordan-4-Retro-'Desert-Moss'-1.jpeg",
                    upperMaterial = "Suede",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "Tan"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 4"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Union-LA-x-Air-Jordan-4-Retro-'Desert-Moss'-1.jpeg" },
                        new Image(){ imageNameID = "Union-LA-x-Air-Jordan-4-Retro-'Desert-Moss'-2.jpeg" },
                        new Image(){ imageNameID = "Union-LA-x-Air-Jordan-4-Retro-'Desert-Moss'-3.jpeg" },
                        new Image(){ imageNameID = "Union-LA-x-Air-Jordan-4-Retro-'Desert-Moss'-4.jpeg" },
                        new Image(){ imageNameID = "Union-LA-x-Air-Jordan-4-Retro-'Desert-Moss'-5.jpeg" },
                        new Image(){ imageNameID = "Union-LA-x-Air-Jordan-4-Retro-'Desert-Moss'-6.jpeg" },
                        new Image(){ imageNameID = "Union-LA-x-Air-Jordan-4-Retro-'Desert-Moss'-7.jpeg" },
                        new Image(){ imageNameID = "Union-LA-x-Air-Jordan-4-Retro-'Desert-Moss'-8.jpeg" },
                        new Image(){ imageNameID = "Union-LA-x-Air-Jordan-4-Retro-'Desert-Moss'-9.jpeg" },
                        new Image(){ imageNameID = "Union-LA-x-Air-Jordan-4-Retro-'Desert-Moss'-10.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Wmns Air Jordan 11 Retro Low 'Bright Citrus'",
                    releaseDate = Convert.ToDateTime("2021-05-07"),
                    colorWay = "White/Bright Citrus",
                    story = "The women’s Air Jordan 11 Retro Low ‘Bright Citrus’ revives a simplistic two-tone colorway initially released in 2001 and previously reissued in 2015 as a kids’ exclusive. The low-top utilizes a white leather upper with webbing lace loops and a shiny patent leather overlay in a matching white finish. Vibrant orange accents stand out on the sneaker’s branding elements, including an embroidered Jumpman on the heel tab. Lightweight cushioning is provided by a Phylon midsole, reinforced underfoot by a carbon fiber spring plate and a translucent orange rubber outsole.",
                    price = 190,
                    usedPrice = 220,
                    view = 0,
                    rating = 0,
                    coverImg = "Wmns-Air-Jordan-11-Retro-Low-'Bright-Citrus'-1.jpeg",
                    upperMaterial = "Patent Leather",
                    brand = new Brand(){ brandNameID = "Jordan"},
                    color = new Color(){ colorNameID = "White"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Air Jordan 11"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Wmns-Air-Jordan-11-Retro-Low-'Bright-Citrus'-1.jpeg" },
                        new Image(){ imageNameID = "Wmns-Air-Jordan-11-Retro-Low-'Bright-Citrus'-2.jpeg" },
                        new Image(){ imageNameID = "Wmns-Air-Jordan-11-Retro-Low-'Bright-Citrus'-3.jpeg" },
                        new Image(){ imageNameID = "Wmns-Air-Jordan-11-Retro-Low-'Bright-Citrus'-4.jpeg" },
                        new Image(){ imageNameID = "Wmns-Air-Jordan-11-Retro-Low-'Bright-Citrus'-5.jpeg" },
                        new Image(){ imageNameID = "Wmns-Air-Jordan-11-Retro-Low-'Bright-Citrus'-6.jpeg" },
                        new Image(){ imageNameID = "Wmns-Air-Jordan-11-Retro-Low-'Bright-Citrus'-7.jpeg" },
                        new Image(){ imageNameID = "Wmns-Air-Jordan-11-Retro-Low-'Bright-Citrus'-8.jpeg" },
                        new Image(){ imageNameID = "Wmns-Air-Jordan-11-Retro-Low-'Bright-Citrus'-9.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Wmns Dunk High 'Crimson Tint'",
                    releaseDate = Convert.ToDateTime("2021-06-27"),
                    colorWay = "Sail/Crimson Tint",
                    story = "The Nike women’s Dunk High ‘Crimson Tint’ showcases a delicate palette that adheres to the traditional color blocking established with the debut ‘Be True to Your School’ series from 1985. The high-top is clad in white leather with contrasting overlays in a creamy pink hue. Traditional Nike branding decorates the sockliner and the woven tag stitched onto the nylon tongue. The two-tone dynamic is repeated on the sneaker’s tooling, featuring white sidewalls and a pastel-hued rubber outsole originally designed to grip the hardwood.",
                    price = 125,
                    usedPrice = 138,
                    view = 0,
                    rating = 0,
                    coverImg = "Wmns-Dunk-High-'Crimson-Tint'-1.jpeg",
                    upperMaterial = "Leather",
                    brand = new Brand(){ brandNameID = "Nike"},
                    color = new Color(){ colorNameID = "Pink"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Dunk"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Wmns-Dunk-High-'Crimson-Tint'-1.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-High-'Crimson-Tint'-2.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-High-'Crimson-Tint'-3.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-High-'Crimson-Tint'-4.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-High-'Crimson-Tint'-5.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-High-'Crimson-Tint'-6.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-High-'Crimson-Tint'-7.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-High-'Crimson-Tint'-8.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Wmns Dunk Low 'Laser Orange'",
                    releaseDate = Convert.ToDateTime("2021-07-09"),
                    colorWay = "Laser Orange/Laser Orange/Sail",
                    story = "The Nike women’s Dunk Low ‘Laser Orange’ steps out in a simple two-tone color scheme that stays true to the vintage hoops shoe’s original color blocking. The upper is executed in clean white leather with bright orange overlays and a signature Swoosh in the same citrus hue. Soft textile lines the low-cut collar for a comfortable fit. Nike branding settles on the sockliner, heel tab and woven tongue tag. The sneaker is underpinned by an orange rubber outsole designed to grip the hardwood.",
                    price = 210,
                    usedPrice = 220,
                    view = 0,
                    rating = 0,
                    coverImg = "Wmns-Dunk-Low-'Laser-Orange'-1.jpeg",
                    upperMaterial = "Leather",
                    brand = new Brand(){ brandNameID = "Nike"},
                    color = new Color(){ colorNameID = "Orange"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Dunk"},
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Wmns-Dunk-Low-'Laser-Orange'-1.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-Low-'Laser-Orange'-2.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-Low-'Laser-Orange'-3.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-Low-'Laser-Orange'-4.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-Low-'Laser-Orange'-5.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-Low-'Laser-Orange'-6.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-Low-'Laser-Orange'-7.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-Low-'Laser-Orange'-8.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-Low-'Laser-Orange'-9.jpeg" },
                        new Image(){ imageNameID = "Wmns-Dunk-Low-'Laser-Orange'-10.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Yeezy 450 'Dark Slate'",
                    releaseDate = Convert.ToDateTime("2021-06-27"),
                    colorWay = "Dark Slate/Dark Slate/Dark Slate",
                    story = "The adidas Yeezy 450 ‘Dark Slate’ delivers a blacked-out iteration of Kanye West’s boundary-pushing silhouette. Stripped of color and exterior branding, the knit upper is secured with an integrated lacing system and topped with an elastic, sock-like cuff. In lieu of a traditional midsole, the rubber outsole sprouts tapered appendages that wrap up the heel and side panels of the deconstructed build, providing support and enhanced durability within its grasp.",
                    price = 283,
                    usedPrice = 303,
                    view = 0,
                    rating = 0,
                    upperMaterial = "",
                    brand = new Brand(){ brandNameID = "Adidas"},
                    color = new Color(){ colorNameID = "Black"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Yeezy 450"},
                    coverImg = "Yeezy-450-'Dark-Slate'-1.jpeg",
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Yeezy-450-'Dark-Slate'-1.jpeg" },
                        new Image(){ imageNameID = "Yeezy-450-'Dark-Slate'-2.jpeg" },
                        new Image(){ imageNameID = "Yeezy-450-'Dark-Slate'-3.jpeg" },
                        new Image(){ imageNameID = "Yeezy-450-'Dark-Slate'-4.jpeg" },
                        new Image(){ imageNameID = "Yeezy-450-'Dark-Slate'-5.jpeg" },
                        new Image(){ imageNameID = "Yeezy-450-'Dark-Slate'-6.jpeg" },
                        new Image(){ imageNameID = "Yeezy-450-'Dark-Slate'-7.jpeg" },
                        new Image(){ imageNameID = "Yeezy-450-'Dark-Slate'-8.jpeg" },
                        new Image(){ imageNameID = "Yeezy-450-'Dark-Slate'-9.jpeg" },
                        new Image(){ imageNameID = "Yeezy-450-'Dark-Slate'-10.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Yeezy 500 'Taupe Light'",
                    releaseDate = Convert.ToDateTime("2021-06-06"),
                    colorWay = "Taupe Light/Taupe Light/Taupe Light",
                    story = "The adidas Yeezy 500 ‘Taupe Light’ steps out in an understated monochromatic colorway that allows the sneaker’s premium construction to come to the fore. Open mesh makes up the majority of the upper, fortified with cow suede and leather overlays throughout. Reflective piping around the eyelets provides a hi-vis element, while a rubber midfoot wrap offers enhanced durability. The layered build is supported by an adiPRENE+ midsole inspired by Kobe Bryant’s third signature shoe, the adidas KB8 3.",
                    price = 235,
                    usedPrice = 197,
                    view = 0,
                    rating = 0,
                    upperMaterial = "Suede",
                    brand = new Brand(){ brandNameID = "Adidas"},
                    color = new Color(){ colorNameID = "Tan"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Yeezy 500"},
                    coverImg = "Yeezy-500-'Taupe-Light'-1.jpeg",
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-1.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-2.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-3.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-4.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-5.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-6.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-7.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-8.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-9.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-10.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-11.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Yeezy Boost 350 V2 'Mono Clay'",
                    releaseDate = Convert.ToDateTime("2021-06-19"),
                    colorWay = "Clay/Clay/Clay",
                    story = "Dropping alongside three companion colorways in a similar one-note finish, the adidas Yeezy Boost 350 V2 ‘Mono Clay’ updates the minimalist silhouette with an upper constructed from monofilament mesh. The lightweight material is rendered in a pale coral hue and reinforced with an internal cage. A webbing pull tab is affixed to the heel, lining up with tonal stripe detailing on the lateral side. The sneaker rides on a standard full-length Boost midsole with rubber-wrapped sidewalls. This shoe released exclusively in the Asia Pacific and China.",
                    price = 223,
                    usedPrice = 250,
                    view = 0,
                    rating = 0,
                    upperMaterial = "Primeknit",
                    brand = new Brand(){ brandNameID = "Adidas"},
                    color = new Color(){ colorNameID = "Orange"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Yeezy 500"},
                    coverImg = "Yeezy-500-'Taupe-Light'-1.jpeg",
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-1.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-2.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-3.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-4.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-5.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-6.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-7.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-8.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-9.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-10.jpeg" },
                        new Image(){ imageNameID = "Yeezy-500-'Taupe-Light'-11.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Yeezy Boost 700 'Enflame Amber'",
                    releaseDate = Convert.ToDateTime("2021-06-12"),
                    colorWay = "Enflame Amber/Enflame Amber/Enflame Amber",
                    story = "The adidas Yeezy Boost 700 ‘Enflame Amber’ features muted earth tones on the upper, constructed from breathable beige mesh with dark brown suede overlays throughout the midfoot. A tonal beige toe cap reinforces an unexpected pop of blue mesh on the toe box. Responsive cushioning arrives via a full-length drop-in Boost midsole, housed within a coral-hued EVA carrier and made visible through cut-out detailing on the herringbone-traction rubber outsole.",
                    price = 305,
                    usedPrice = 280,
                    view = 0,
                    rating = 0,
                    upperMaterial = "",
                    brand = new Brand(){ brandNameID = "Adidas"},
                    color = new Color(){ colorNameID = "Tan"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Yeezy 700"},
                    coverImg = "Yeezy-Boost-700-'Enflame-Amber'-1.jpeg",
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Yeezy-Boost-700-'Enflame-Amber'-1.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-'Enflame-Amber'-2.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-'Enflame-Amber'-3.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-'Enflame-Amber'-4.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-'Enflame-Amber'-5.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-'Enflame-Amber'-6.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-'Enflame-Amber'-7.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-'Enflame-Amber'-8.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-'Enflame-Amber'-9.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Boost-700-'Enflame-Amber'-10.jpeg" },
                    }
                },
                new Product()
                {
                    productNameID = "Yeezy Foam Runner 'Mineral Blue'",
                    releaseDate = Convert.ToDateTime("2021-05-30"),
                    colorWay = "Mineral Blue/Mineral Blue/Mineral Blue",
                    story = "The adidas Yeezy Foam Runner 'Mineral Blue' coats the hybrid silhouette in a monochromatic finish. The slip-on blends elements of sneakers and sandals, arriving in soft yet durable foam. A series of large and small ventilation ports enhance airflow, with branding limited to a discreet adidas logo underfoot.",
                    price = 196,
                    usedPrice = 234,
                    view = 0,
                    rating = 0,
                    upperMaterial = "",
                    brand = new Brand(){ brandNameID = "Adidas"},
                    color = new Color(){ colorNameID = "Blue"},
                    category = new Category(){ categoryNameID = "Lifestyle"},
                    type = new Data.Type(){typeNameID = "Sneaker"},
                    silhouette = new Silhouette{silhouetteNameID = "Yeezy Foam Runner"},
                    coverImg = "Yeezy-Foam-Runner-'Mineral-Blue'-1.jpeg",
                    images = new List<Image>()
                    {
                        new Image(){ imageNameID = "Yeezy-Foam-Runner-'Mineral-Blue'-1.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Foam-Runner-'Mineral-Blue'-2.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Foam-Runner-'Mineral-Blue'-3.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Foam-Runner-'Mineral-Blue'-4.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Foam-Runner-'Mineral-Blue'-5.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Foam-Runner-'Mineral-Blue'-6.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Foam-Runner-'Mineral-Blue'-7.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Foam-Runner-'Mineral-Blue'-8.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Foam-Runner-'Mineral-Blue'-9.jpeg" },
                        new Image(){ imageNameID = "Yeezy-Foam-Runner-'Mineral-Blue'-10.jpeg" },
                    }
                },
            };
            foreach(var i in data)
            {
                if(service.findByID(i.productNameID) == null)
                {
                    service.create(i);
                }
            }
            #endregion end
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
