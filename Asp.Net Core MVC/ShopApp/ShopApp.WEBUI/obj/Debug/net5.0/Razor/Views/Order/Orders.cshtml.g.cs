#pragma checksum "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f23c88e5ce1d123b1523ed6a4824d90ea7a05ff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Orders), @"mvc.1.0.view", @"/Views/Order/Orders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23c88e5ce1d123b1523ed6a4824d90ea7a05ff6", @"/Views/Order/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8534d75463e8ebf0245e30ecb330c6d5bbf236e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n<h1>Siparişleriniz</h1>\r\n<hr />\r\n\r\n");
#nullable restore
#line 8 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
 foreach (var order in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table-sm mb-3\">\r\n        <thead class=\"bg-primary\">\r\n        <tr>\r\n        <td colspan=\"2\">Sipariş No: #");
#nullable restore
#line 14 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
                                Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <th>Fiyat</th>\r\n        <th>Miktar</th>\r\n        </tr>\r\n        </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
 foreach (var orderItem in order.OrderItems)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f23c88e5ce1d123b1523ed6a4824d90ea7a05ff65366", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 450, "~/img/", 450, 6, true);
#nullable restore
#line 23 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
AddHtmlAttributeValue("", 456, orderItem.ImageUrl, 456, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
       Write(orderItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
       Write(orderItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
       Write(orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n                <tfoot>\r\n                <tr>\r\n                <td colspan=\"2\">Müşteri Adı:</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
               Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
                                Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td rowspan=\"5\">Total: ");
#nullable restore
#line 34 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
                                  Write(order.TotalPrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                <td colspan=\"2\">Adres:</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
               Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                <td colspan=\"2\">Mail:</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
               Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                <td colspan=\"2\">Telefon:</td>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
               Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                <td colspan=\"2\">Sipariş Tarihi:</td>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"
               Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                \r\n</tfoot>\r\n</table>\r\n");
#nullable restore
#line 56 "C:\Users\aatas\Desktop\Asp.Net Core MVC\ShopApp\ShopApp.WEBUI\Views\Order\Orders.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
