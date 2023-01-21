#pragma checksum "C:\Users\Viraldo\Desktop\Northwind Finished\MVC_Odev\MVC_Odev\Views\Home\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f2877b439435c576a5cf91938deb41ae2d26ac5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Products), @"mvc.1.0.view", @"/Views/Home/Products.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2877b439435c576a5cf91938deb41ae2d26ac5", @"/Views/Home/Products.cshtml")]
    #nullable restore
    public class Views_Home_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Viraldo\Desktop\Northwind Finished\MVC_Odev\MVC_Odev\Views\Home\Products.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f2877b439435c576a5cf91938deb41ae2d26ac52992", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Products</title>\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f2877b439435c576a5cf91938deb41ae2d26ac54046", async() => {
                WriteLiteral(@"
    <div class=""container bodyContainerMain mt-5"">
        <div class=""row"">
            <h1>Products</h1>
            <!--Product listesini listeleyin.-->
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>ProductName</th>
                        <th>UnitPrice</th>
                        <th>UnitsInStock</th>
                        <th scope=""col"">#</th>
                    </tr>
                </thead>

                <tbody class=""table-group-divider"">
");
#nullable restore
#line 29 "C:\Users\Viraldo\Desktop\Northwind Finished\MVC_Odev\MVC_Odev\Views\Home\Products.cshtml"
                     foreach (var product in ViewBag.Products as List<MVC_Odev.Models.Product>)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 32 "C:\Users\Viraldo\Desktop\Northwind Finished\MVC_Odev\MVC_Odev\Views\Home\Products.cshtml"
                           Write(product.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 33 "C:\Users\Viraldo\Desktop\Northwind Finished\MVC_Odev\MVC_Odev\Views\Home\Products.cshtml"
                           Write(product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 34 "C:\Users\Viraldo\Desktop\Northwind Finished\MVC_Odev\MVC_Odev\Views\Home\Products.cshtml"
                           Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 35 "C:\Users\Viraldo\Desktop\Northwind Finished\MVC_Odev\MVC_Odev\Views\Home\Products.cshtml"
                           Write(product.UnitsInStock);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td><a href=\"#\" class=\"btn btn-outline-danger btn-sm\"><img src=\"https://icon-library.com/images/delete-icon-png/delete-icon-png-19.jpg\" style=\"width:10px; height:10px\" /> </a></td>\n                        </tr>\n");
#nullable restore
#line 38 "C:\Users\Viraldo\Desktop\Northwind Finished\MVC_Odev\MVC_Odev\Views\Home\Products.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\n            </table>\n            <div class=\"d-grid gap-2\">\n                <a href=\"/Home/ProductCreate\" class=\"btn btn-dark\" type=\"button\">Ürün Oluştur</a>\n            </div>\n        </div>\n    </div>\n");
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
