#pragma checksum "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Brand\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e52ace9c58169de9cde596d58883ea0d095b6bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brand_Index), @"mvc.1.0.view", @"/Views/Brand/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e52ace9c58169de9cde596d58883ea0d095b6bb", @"/Views/Brand/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d0af9c120e4b2471629d5a4db9b224bd02540bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Brand_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(String brand, List<Ecomerece_Web.Data.Product> products)>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"PageLayout_PageAlignmentListProduct\">\r\n\r\n    <div class=\"CollectionHeader_CollectionHeaderWrapper\">\r\n        <div class=\"CollectionHeader_CollectionHeaderInfo\">\r\n            <h1 class=\"CollectionHeader_CollectionHeadOne\">");
#nullable restore
#line 6 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Brand\Index.cshtml"
                                                      Write(Model.brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p class=\"CollectionHeader_CollectionDescription\"></p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 10 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Brand\Index.cshtml"
     if (Model.products != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container\" style=\"max-width: 91%;\" id=\"itemList\">\r\n            ");
#nullable restore
#line 13 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Brand\Index.cshtml"
       Write(await Component.InvokeAsync("ProductList", new { products = Model.products }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 15 "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Brand\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(String brand, List<Ecomerece_Web.Data.Product> products)> Html { get; private set; }
    }
}
#pragma warning restore 1591