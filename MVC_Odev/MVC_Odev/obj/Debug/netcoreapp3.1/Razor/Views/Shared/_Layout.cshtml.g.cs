#pragma checksum "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dec56527ecb5b359d5157a1858382bc6674f488"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dec56527ecb5b359d5157a1858382bc6674f488", @"/Views/Shared/_Layout.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Shared\_Layout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dec56527ecb5b359d5157a1858382bc6674f4882991", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>_Layout</title>
    <link rel=""stylesheet"" href=""/bootstrap/css/bootstrap.css"" />
    <link rel=""stylesheet"" href=""/Css/CustomCss.css"" />
    <script src=""/bootstrap/js/bootstrap.js""></script>
    <script src=""/Js/CustomScript.js""></script>
    }
    <style>
        #myVideo1 {
            width: 100vw;
            height: 100vh;
            object-fit: cover;
            position: fixed;
            left: 0;
            right: 0;
            top: 0;
            bottom: 0;
            z-index: -1;
        }
    </style>
");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dec56527ecb5b359d5157a1858382bc6674f4884566", async() => {
                WriteLiteral(@"
    <video autoplay muted loop id=""myVideo1"">
        <source src=""/smokeVid.mp4"" type=""video/mp4"">
    </video>
    <header class=""p-3 text-bg-dark"">
        <div class=""container"">
            <div class=""d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start"">
                <ul class=""nav col-12 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0"">
                    <li><a href=""/home/index"" class=""nav-link px-2 text-secondary"">Home</a></li>
                    <li><a href=""/home/products"" class=""nav-link px-2 text-white"">Products</a></li>
                    <li><a href=""/home/customers"" class=""nav-link px-2 text-white"">Customers</a></li>
                    <li><a href=""/Home/Employee"" class=""nav-link px-2 text-white"">Employees</a></li>
                    <li><a href=""/Home/Orders"" class=""nav-link px-2 text-white"">Orders</a></li>
                </ul>

                <form class=""col-12 col-lg-auto mb-3 mb-lg-0 me-lg-3"" role=""search"">
                    <input ");
                WriteLiteral(@"type=""search"" class=""form-control form-control-dark text-bg-dark"" placeholder=""Search..."" aria-label=""Search"">
                </form>

                <div class=""text-end"">
                    <a href=""/Home/Login"" class=""btn btn-outline-light me-2"">Login</a>
                    <a href=""/Home/Register"" class=""btn btn-warning"">Sign-up</a>
                    <a href=""/home/sepet"" class=""btn btn-outline-ligh""><img src=""https://cdn.discordapp.com/attachments/1049744598978789508/1065902486654832751/white-shopping-cart-icon-png-19.jpg"" style=""width:20px; height:20px;""/> Sepet</a>
                </div>
            </div>
        </div>
    </header>

    ");
#nullable restore
#line 59 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

    <div class=""container"">
        <footer class=""d-flex flex-wrap justify-content-between align-items-center py-3 my-4 border-top"">
            <div class=""col-md-4 d-flex align-items-center"">
                <a href=""/"" class=""mb-3 me-2 mb-md-0 text-muted text-decoration-none lh-1"">
                    <svg class=""bi"" width=""30"" height=""24""><use xlink:href=""#bootstrap""></use></svg>
                </a>
                <span class=""mb-3 mb-md-0 text-muted"">Northwind © 2022 Company, Inc</span>
            </div>

            <ul class=""nav col-md-4 justify-content-end list-unstyled d-flex"">
                <li class=""ms-3""><a class=""text-muted"" href=""#""><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#twitter""></use></svg></a></li>
                <li class=""ms-3""><a class=""text-muted"" href=""#""><svg class=""bi"" width=""24"" height=""24""><use xlink:href=""#instagram""></use></svg></a></li>
                <li class=""ms-3""><a class=""text-muted"" href=""#""><svg class=""bi"" width=""24"" height=""24""><use xlink:hr");
                WriteLiteral("ef=\"#facebook\"></use></svg></a></li>\n            </ul>\n        </footer>\n    </div>\n");
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
