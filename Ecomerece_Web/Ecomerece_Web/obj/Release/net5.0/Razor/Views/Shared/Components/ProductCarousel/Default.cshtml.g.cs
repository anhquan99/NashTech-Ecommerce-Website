#pragma checksum "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81362fffee373506eecb59d7b92c034403f09bc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductCarousel_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductCarousel/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81362fffee373506eecb59d7b92c034403f09bc1", @"/Views/Shared/Components/ProductCarousel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d0af9c120e4b2471629d5a4db9b224bd02540bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductCarousel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(List<Ecomerece_Web.Data.Product> products, String name, String url)>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ProductTemplateCarouselItem_Wrapper"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"ModuleSection ProductsYouMayLike_Wrapper\">\r\n    <div class=\"ModuleSectionHeader_Wrapper\">\r\n        <h3 class=\"ModuleSectionTitle\">");
#nullable restore
#line 5 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
                                  Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 6 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
         if (Model.url != "")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"ButtonLink_Button ModuleSectionHeader_DesktopButton\"");
            BeginWriteAttribute("href", " href=\"", 355, "\"", 372, 1);
#nullable restore
#line 8 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
WriteAttributeValue("", 362, Model.url, 362, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span>See All</span></a>\r\n");
#nullable restore
#line 9 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"ModuleSectionContent\">\r\n        <div class=\"SideScrollingCarousel_Navigation\">\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 538, "\"", 575, 3);
            WriteAttributeValue("", 548, "scrollXRight(\'", 548, 14, true);
#nullable restore
#line 13 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
WriteAttributeValue("", 562, ViewBag.id, 562, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 573, "\')", 573, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"LeftRightButtons_NavigationButton LeftRightButtons_LeftButtonStyled\">\r\n                <svg version=\"1.1\" xlmns=\"http://www.w3.org/2000/svg\" xlmnsxlink=\"http://www.w3.org/1999/xlink\"");
            BeginWriteAttribute("class", "\r\n                     class=\"", 766, "\"", 796, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""4px"" height=""8px"" viewBox=""0 0 11 17"">
                    <title>Left Caret</title>
                    <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"" opacity=""1"">
                        <g transform=""translate(-77.000000, -50.000000)"" stroke=""#0b0b0b"" stroke-width=""2"">
                            <polyline transform=""translate(83.038462, 58.500000) rotate(-180.000000) translate(-83.038462, -58.500000)""
                                      points=""79 51 87.0769231 58.7039082 79 66""></polyline>
                        </g>
                    </g>
                </svg>
            </button><button");
            BeginWriteAttribute("onclick", " onclick=\"", 1440, "\"", 1476, 3);
            WriteAttributeValue("", 1450, "scrollXLeft(\'", 1450, 13, true);
#nullable restore
#line 24 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
WriteAttributeValue("", 1463, ViewBag.id, 1463, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1474, "\')", 1474, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"LeftRightButtons_NavigationButton LeftRightButtons_RightButtonStyled\">\r\n                <svg version=\"1.1\" xlmns=\"http://www.w3.org/2000/svg\" xlmnsxlink=\"http://www.w3.org/1999/xlink\"");
            BeginWriteAttribute("class", "\r\n                     class=\"", 1668, "\"", 1698, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""4px"" height=""8px"" viewBox=""0 0 11 17"">
                    <title>Right Caret</title>
                    <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                        <g transform=""translate(-118.000000, -50.000000)"" stroke=""#0b0b0b"" stroke-width=""2"">
                            <polyline transform=""translate(123.038462, 58.500000) rotate(-360.000000) translate(-123.038462, -58.500000) ""
                                      points=""119 51 127.076923 58.7039082 119 66""></polyline>
                        </g>
                    </g>
                </svg>
            </button>
        </div>
");
#nullable restore
#line 37 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
         if (Model.products.Count > 4)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"SideScrollingCarousel_Carousel \"");
            BeginWriteAttribute("id", " id=\"", 2455, "\"", 2471, 1);
#nullable restore
#line 39 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
WriteAttributeValue("", 2460, ViewBag.id, 2460, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 40 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
                 foreach (var i in Model.products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81362fffee373506eecb59d7b92c034403f09bc19735", async() => {
                WriteLiteral("\r\n                        <img");
                BeginWriteAttribute("alt", " alt=\"", 2701, "\"", 2707, 0);
                EndWriteAttribute();
                WriteLiteral(" sizes=\"(min-width: 640px) 20vw, 50vw\"");
                BeginWriteAttribute("src", " src=\"", 2746, "\"", 2772, 2);
                WriteAttributeValue("", 2752, "/utility/", 2752, 9, true);
#nullable restore
#line 44 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
WriteAttributeValue("", 2761, i.coverImg, 2761, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                             class=""sc-htpNat ProductTemplateCarouselItem_ProductImage"">
                        <div class=""ProductTemplateCarouselItem_ProductDetailsContainer"">
                            <div class=""ProductTemplateCarouselItem_ProductDetails"">
                                <div class=""ProductTemplateCarouselItem_ProductName"">
                                    ");
#nullable restore
#line 49 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
                               Write(i.productNameID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2643, "~/Product/", 2643, 10, true);
#nullable restore
#line 43 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
AddHtmlAttributeValue("", 2653, i.productNameID, 2653, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 54 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 56 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductCarousel\Default.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"FauxScrollbar_Track\">\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(List<Ecomerece_Web.Data.Product> products, String name, String url)> Html { get; private set; }
    }
}
#pragma warning restore 1591
