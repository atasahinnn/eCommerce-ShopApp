#pragma checksum "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68721239b112eb0aeed4adc4116f38c277479db3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
#line 2 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using ShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using ShopApp.WEBUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using ShopApp.WEBUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\_ViewImports.cshtml"
using ShopApp.WEBUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68721239b112eb0aeed4adc4116f38c277479db3", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8534d75463e8ebf0245e30ecb330c6d5bbf236e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"navbar bg-primary navbar-dark navbar-expand-sm\">\r\n<div class=\"container-fluid\">\r\n<a href=\"/\" class=\"navbar-brand\">ShopApp</a>\r\n<ul class=\"navbar-nav mr-auto\">\r\n    <li class=\"nav-item\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68721239b112eb0aeed4adc4116f38c277479db35090", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a href=\"/products\" class=\"nav-link\">Ürünler</a>\r\n    </li>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Shared\_navbar.cshtml"
     if (User.Identity.IsAuthenticated)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\">\r\n            <a href=\"/cart\" class=\"nav-link\">Sepetim</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a href=\"/orders\" class=\"nav-link\">Siparişlerim</a>\r\n        </li>\r\n");
#nullable restore
#line 22 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Shared\_navbar.cshtml"
         if (User.IsInRole("admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <li class=""nav-item"">
                <a href=""/admin/products"" class=""nav-link"">Admin - Ürünler</a>
            </li>
            <li class=""nav-item"">
                <a href=""/admin/categories"" class=""nav-link"">Admin - Kategoriler</a>
            </li>
            <li class=""nav-item"">
                <a href=""/admin/role/list"" class=""nav-link"">Roller</a>
            </li>
            <li class=""nav-item"">
                <a href=""/admin/user/list"" class=""nav-link"">Kullanıcılar</a>
            </li>
");
#nullable restore
#line 36 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Shared\_navbar.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Shared\_navbar.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n\r\n<ul class=\"navbar-nav ml-auto\">\r\n");
#nullable restore
#line 43 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Shared\_navbar.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\">\r\n            <a href=\"/account/manage\" class=\"nav-link\">\r\n                ");
#nullable restore
#line 47 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Shared\_navbar.cshtml"
           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a href=\"/account/logout\" class=\"nav-link\">Çıkış</a>\r\n        </li>\r\n");
#nullable restore
#line 53 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Shared\_navbar.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item\">\r\n            <a href=\"/account/login\" class=\"nav-link\">Giriş Yap</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a href=\"/account/register\" class=\"nav-link\">Kayıt Ol</a>\r\n        </li>\r\n");
#nullable restore
#line 62 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Shared\_navbar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n\r\n</div>\r\n</div>  \r\n");
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
