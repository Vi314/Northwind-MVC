#pragma checksum "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Home\Customers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f4f5af3c60a848ac25c442fd553b103439c5e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Customers), @"mvc.1.0.view", @"/Views/Home/Customers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f4f5af3c60a848ac25c442fd553b103439c5e2", @"/Views/Home/Customers.cshtml")]
    #nullable restore
    public class Views_Home_Customers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Home\Customers.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2f4f5af3c60a848ac25c442fd553b103439c5e23018", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Customers</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2f4f5af3c60a848ac25c442fd553b103439c5e24073", async() => {
                WriteLiteral(@"
    <div class=""container bodyContainerMain mt-5"">
        <div class=""row"">
            <h1>Customers</h1>
            <div class=""bd-example-snippet bd-code-snippet"">
                <div class=""bd-example"">
                    <table class=""table table-striped table-hover"">
                        <thead>
                            <tr>
                                <th scope=""col"">ID</th>
                                <th scope=""col"">Şirket İsmi</th>
                                <th scope=""col"">İsim</th>
                                <th scope=""col"">Pozisyon</th>
                                <th scope=""col"">Telefon</th>
                                <th scope=""col"">#</th>
                            </tr>
                        </thead>
                        <tbody class=""table-group-divider"">
");
#nullable restore
#line 30 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Home\Customers.cshtml"
                             foreach (var customers in ViewBag.Customer){

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 32 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Home\Customers.cshtml"
                                   Write(customers.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 33 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Home\Customers.cshtml"
                                   Write(customers.CompanyName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 34 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Home\Customers.cshtml"
                                   Write(customers.CustomerName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 35 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Home\Customers.cshtml"
                                   Write(customers.CustomerTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 36 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Home\Customers.cshtml"
                                   Write(customers.CustomerPhone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                    <td>\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 1542, "\"", 1578, 2);
                WriteAttributeValue("", 1549, "/home/customers/", 1549, 16, true);
#nullable restore
#line 38 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Home\Customers.cshtml"
WriteAttributeValue("", 1565, customers.Id, 1565, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-danger btn-sm\"><img src=\"https://icon-library.com/images/delete-icon-png/delete-icon-png-19.jpg\" style=\"width:20px; height:20px\" /></a>\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 1781, "\"", 1824, 2);
                WriteAttributeValue("", 1788, "/Update/UpdateCustomer/", 1788, 23, true);
#nullable restore
#line 39 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Home\Customers.cshtml"
WriteAttributeValue("", 1811, customers.Id, 1811, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-outline-warning btn-sm""><img src=""https://imgs.search.brave.com/fkbXOaZaXvX5qWDVpsrcWcqImegnnQoUTQ-R35b8nwc/rs:fit:512:512:1/g:ce/aHR0cHM6Ly9pY29u/cy5pY29uYXJjaGl2/ZS5jb20vaWNvbnMv/cGFwaXJ1cy10ZWFt/L3BhcGlydXMtYXBw/cy81MTIvc3lzdGVt/LXNvZnR3YXJlLXVw/ZGF0ZS1pY29uLnBu/Zw"" style=""width:20px; height:20px"" /></a>
                                        </td>
                                </tr>
");
#nullable restore
#line 42 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Home\Customers.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </tbody>
                    </table>
                    <hr class=""my-4"">
                    <div class=""d-grid gap-2"">
                        <a href=""/Home/CustomerCreate"" class=""btn btn-dark"" type=""button"">Müşteri Oluştur</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
