#pragma checksum "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a8f591d38281ee686932e26ef3cc8f37761b71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Update_UpdateOrder), @"mvc.1.0.view", @"/Views/Update/UpdateOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3a8f591d38281ee686932e26ef3cc8f37761b71", @"/Views/Update/UpdateOrder.cshtml")]
    #nullable restore
    public class Views_Update_UpdateOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Odev.Models.Order>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateOrder.cshtml"
  
    ViewData["Title"] = "UpdateOrder";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3a8f591d38281ee686932e26ef3cc8f37761b712898", async() => {
                WriteLiteral("\r\n    <style>\r\n        .inputStyle{\r\n            margin-top:10px;\r\n            margin-bottom: 10px;\r\n            justify-content:space-between;\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral(@"



<div class=""container"">
    <div class=""row"">
        <div class=""container bodyContainerMain"">
            <h1>UpdateOrder</h1>
            <form method=""post"">
                <div class=""col-md- 6 inputStyle"">
                    <label class=""input-label"">OrderDate</label>
                    <input class=""form-control"" name=""OrderDate""");
            BeginWriteAttribute("value", " value=\"", 664, "\"", 688, 1);
#nullable restore
#line 25 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateOrder.cshtml"
WriteAttributeValue("", 672, Model.OrderDate, 672, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-6 inputStyle\">\r\n                    <label>CustomerID</label>\r\n                    <input class=\"form-control\" name=\"CustomerID\"");
            BeginWriteAttribute("value", " value=\"", 881, "\"", 906, 1);
#nullable restore
#line 29 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateOrder.cshtml"
WriteAttributeValue("", 889, Model.CustomerID, 889, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"inputStyle\">\r\n                    <label>Freight</label>\r\n                    <input class=\"form-control\" name=\"Freight\"");
            BeginWriteAttribute("value", " value=\"", 1084, "\"", 1106, 1);
#nullable restore
#line 33 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateOrder.cshtml"
WriteAttributeValue("", 1092, Model.Freight, 1092, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"inputStyle\">\r\n                    <label>ShipAdress</label>\r\n                    <input class=\"form-control\" name=\"ShipAdress\"");
            BeginWriteAttribute("value", " value=\"", 1290, "\"", 1315, 1);
#nullable restore
#line 37 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateOrder.cshtml"
WriteAttributeValue("", 1298, Model.ShipAdress, 1298, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"inputStyle\">\r\n                    <label>ShipVia</label>\r\n                    <input class=\"form-control\" name=\"ShipVia\"");
            BeginWriteAttribute("value", " value=\"", 1493, "\"", 1515, 1);
#nullable restore
#line 41 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateOrder.cshtml"
WriteAttributeValue("", 1501, Model.ShipVia, 1501, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-outline-warning\">Güncelle</button>\r\n            </form>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Odev.Models.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591