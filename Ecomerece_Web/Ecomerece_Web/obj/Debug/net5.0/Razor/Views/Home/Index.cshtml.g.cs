#pragma checksum "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "661c17431102c3d94ca6dfad1f24841d4d33915b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\_ViewImports.cshtml"
using Ecomerece_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\_ViewImports.cshtml"
using Ecomerece_Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661c17431102c3d94ca6dfad1f24841d4d33915b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d0af9c120e4b2471629d5a4db9b224bd02540bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- body -->
<div class=""PageLayout_PageAlignment"">
    <div class=""HomeHeroSection_Container"">
        <img src=""/utility/jordan4.jpg"" style=""width:100%;"">
        <div class=""HomeHeroSection_Content"">
            <h2>Air Jordam 4 Retro 'White Oreo'</h2>
        </div>
        <a aria-label=""Link to  - Air Jordan 4 Retro 'White Oreo'"" class=""HomeHeroSection_ClickableOverlay"" href=""#""></a>
    </div>
    ");
#nullable restore
#line 10 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("ProductCarousel"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""ModuleSection ProductsYouMayLike_Wrapper"">
        <div class=""ModuleSectionHeader_Wrapper"">
            <h3 class=""ModuleSectionTitle"">Top 20 Trending</h3>
            <a class=""ButtonLink_Button ModuleSectionHeader_DesktopButton"" href=""#""><span>See All</span></a>
        </div>
        <div class=""container"" style=""max-width: 100%;"">
");
#nullable restore
#line 17 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Home\Index.cshtml"
             for (int i = 0; i < 4; i++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Home\Index.cshtml"
           Write(Html.Raw("<div class='row'>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Home\Index.cshtml"
                                              ;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Home\Index.cshtml"
                 for (int x = 0; x < 3; x++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("Product", "Ranking"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Home\Index.cshtml"
                                                                      ;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Home\Index.cshtml"
           Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Home\Index.cshtml"
                                   ;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
    <div class=""align-center-justify-center full-width"" style=""height: 90px;"">
        <p onclick=""backToTop()"" class=""plainmedium10caps  underline-hover pointer"" style=""margin: 0;margin-right: 6px;"">
            BACK
            TO TOP
        </p><svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 8.33 5"" width=""10px"" height=""10px"" class=""arrow pointer ""
                 style=""transform: rotate(0deg);"">
            <polyline points=""1.17 4.25 4.17 1.25 7.17 4.25"" fill=""none"" stroke=""#0b0b0b"" stroke-miterlimit=""10""
                      stroke-width=""1.5""></polyline>
        </svg>
    </div>

</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
