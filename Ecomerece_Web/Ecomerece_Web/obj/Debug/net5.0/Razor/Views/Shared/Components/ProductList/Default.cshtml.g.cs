#pragma checksum "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad9b17b4f8066dbdda6421090ec936065caa0023"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad9b17b4f8066dbdda6421090ec936065caa0023", @"/Views/Shared/Components/ProductList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d0af9c120e4b2471629d5a4db9b224bd02540bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ecomerece_Web.Data.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!-- body -->\r\n");
#nullable restore
#line 3 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductList\Default.cshtml"
     for (int i = 1; i <= Model.Count;)
    {
        int temp = i + 4;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductList\Default.cshtml"
   Write(Html.Raw("<div class='row flex-nowrap'>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductList\Default.cshtml"
                                                  ;
        for (int k = i; k < temp && k <= Model.Count; k++, i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductList\Default.cshtml"
       Write(await Component.InvokeAsync("Product", new { product = Model.ElementAt(i - 1) }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductList\Default.cshtml"
                                                                                             ;

        }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductList\Default.cshtml"
   Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\ProductList\Default.cshtml"
                           ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ecomerece_Web.Data.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
