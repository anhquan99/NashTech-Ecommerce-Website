#pragma checksum "E:\Work\NashTech\Project\NashTech-Ecommerce-Website\Ecomerece_Web\Ecomerece_Web\Views\Shared\Components\AuthenticateForm\RegisterForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e88cf4730abae43737130e9bb746127f9ebb663f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AuthenticateForm_RegisterForm), @"mvc.1.0.view", @"/Views/Shared/Components/AuthenticateForm/RegisterForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e88cf4730abae43737130e9bb746127f9ebb663f", @"/Views/Shared/Components/AuthenticateForm/RegisterForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d0af9c120e4b2471629d5a4db9b224bd02540bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AuthenticateForm_RegisterForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("RegisterForm_Form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("RegisterForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e88cf4730abae43737130e9bb746127f9ebb663f4186", async() => {
                WriteLiteral(@"
    <div class=""Hero_HeroPane RegisterForm_HeroPane"">
        <div class=""Hero_HeroPaneContent RegisterForm_HeroPaneContent"">
            <header class=""RegisterForm_Header"">
                <h1 class=""RegisterForm_Title"">Sign Up</h1>
            </header>
            <main class=""RegisterForm_Main"">
                <div class=""MaterialInput_Content"">
                    <label class=""MaterialInput_Label"">
                        <input autocomplete=""name"" id=""full-name"" label=""Full Name"" name=""name"" type=""text""
                               aria-label=""Full Name"" class=""MaterialInput_Input""");
                BeginWriteAttribute("value", " value=\"", 669, "\"", 677, 0);
                EndWriteAttribute();
                WriteLiteral(@"><span class=""MaterialInput_LabelCopy"">
                            Full
                            Name
                        </span>
                    </label>
                </div>
                <div class=""MaterialInput_Content"">
                    <label class=""MaterialInput_Label"">
                        <input id=""email""
                               label=""Email"" name=""username"" type=""email""");
                BeginWriteAttribute("autocomplete", " autocomplete=\"", 1100, "\"", 1115, 0);
                EndWriteAttribute();
                WriteLiteral(" aria-label=\"Email\"\r\n                               class=\"MaterialInput_Input\"");
                BeginWriteAttribute("value", " value=\"", 1195, "\"", 1203, 0);
                EndWriteAttribute();
                WriteLiteral(@"><span class=""
                                            MaterialInput_LabelCopy"">Email</span>
                    </label>
                </div>
                <div class=""MaterialInput_Content"">
                    <label class=""MaterialInput_Label"">
                        <input data-qa=""register_password_input""
                               id=""password"" label=""Password"" name=""password"" type=""password""");
                BeginWriteAttribute("autocomplete", " autocomplete=\"", 1626, "\"", 1641, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                               aria-label=\"Password\" class=\"MaterialInput_Input\"");
                BeginWriteAttribute("value", " value=\"", 1724, "\"", 1732, 0);
                EndWriteAttribute();
                WriteLiteral(@"><span class=""
                                            MaterialInput_LabelCopy"">Password</span>
                    </label>
                </div>
                <div class=""MaterialInput_Content"">
                    <label class=""MaterialInput_Label"">
                        <input data-qa=""register_confirm_password_input""
                               id=""confirm-password"" label=""Confirm Password"" name=""confirmPassword"" type=""password""");
                BeginWriteAttribute("autocomplete", "\r\n                               autocomplete=\"", 2189, "\"", 2236, 0);
                EndWriteAttribute();
                WriteLiteral(" aria-label=\"Confirm Password\" class=\"MaterialInput_Input\"");
                BeginWriteAttribute("value", "\r\n                               value=\"", 2295, "\"", 2335, 0);
                EndWriteAttribute();
                WriteLiteral(@"><span class=""
                                            MaterialInput_LabelCopy"">
                            Confirm
                            Password
                        </span>
                    </label>
                </div>
                <div class=""RegisterForm_Terms"">
                    <span>
                        <span>
                            By creating an account you
                            agree to our
                        </span> <a data-qa=""terms_link"" href=""#"">Terms</a> <span>and</span>
                        <a data-qa=""privacy_link"" href=""#"">Privacy</a>
                    </span>
                </div>
            </main>
        </div>
        <nav class=""Hero_HeroPaneLoginActions"">
            <a class=""Hero_Link"" href=""#"">
                <button onclick=""showForm('RegisterForm','LoginForm')""
                        type=""button"" class=""GoatButton_Wrapper Hero_Button"">
                    Back
                </button>
            </a");
                WriteLiteral("><span class=\"Hero_Border\">\r\n                <button");
                BeginWriteAttribute("disabled", " disabled=\"", 3412, "\"", 3423, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"submit\" class=\"GoatButton_Wrapper Hero_Button\">\r\n                    Sign\r\n                    Up\r\n                </button>\r\n            </span>\r\n        </nav>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
