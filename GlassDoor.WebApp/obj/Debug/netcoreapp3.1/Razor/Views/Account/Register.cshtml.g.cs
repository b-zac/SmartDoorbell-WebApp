#pragma checksum "C:\Users\Bartosz\source\repos\GlassDoor.WebAPI\GlassDoor.WebApp\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "063ce7fdcc6883a39508814af452e3347ae4bb73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
#line 1 "C:\Users\Bartosz\source\repos\GlassDoor.WebAPI\GlassDoor.WebApp\Views\_ViewImports.cshtml"
using GlassDoor.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bartosz\source\repos\GlassDoor.WebAPI\GlassDoor.WebApp\Views\_ViewImports.cshtml"
using GlassDoor.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"063ce7fdcc6883a39508814af452e3347ae4bb73", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7deb6afff5f1a351d512ae62524814509aa8e43f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GlassDoor.Data.Entities.Models.UserModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Bartosz\source\repos\GlassDoor.WebAPI\GlassDoor.WebApp\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Register</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "063ce7fdcc6883a39508814af452e3347ae4bb733886", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Bartosz\source\repos\GlassDoor.WebAPI\GlassDoor.WebApp\Views\Account\Register.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>
    <div class=""form-group"">
        <label for=""exampleInputEmail1"">Email address</label>
        <input type=""email"" name=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"">
        <small id=""emailHelp"" class=""form-text text-muted"">We'll never share your email with anyone else.</small>
    </div>
    <div class=""form-group"">
        <label");
                BeginWriteAttribute("for", " for=\"", 598, "\"", 604, 0);
                EndWriteAttribute();
                WriteLiteral(">Display Name</label>\r\n        <input type=\"text\" name=\"displayname\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 694, "\"", 699, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-describedby", " aria-describedby=\"", 700, "\"", 719, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label");
                BeginWriteAttribute("for", " for=\"", 779, "\"", 785, 0);
                EndWriteAttribute();
                WriteLiteral(">Username</label>\r\n        <input type=\"text\" name=\"username\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 868, "\"", 873, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-describedby", " aria-describedby=\"", 874, "\"", 893, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    </div>
    <div class=""form-group"">
        <label for=""exampleInputPassword1"">Password</label>
        <input type=""password"" name=""password"" class=""form-control"" id=""exampleInputPassword1"">
    </div>

    <button type=""submit"" class=""btn btn-primary"">Submit</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GlassDoor.Data.Entities.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
