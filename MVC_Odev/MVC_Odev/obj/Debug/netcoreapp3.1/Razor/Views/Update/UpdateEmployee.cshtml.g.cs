#pragma checksum "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611acb6b865f7f7e98e3b0235113392ea2030da6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Update_UpdateEmployee), @"mvc.1.0.view", @"/Views/Update/UpdateEmployee.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611acb6b865f7f7e98e3b0235113392ea2030da6", @"/Views/Update/UpdateEmployee.cshtml")]
    #nullable restore
    public class Views_Update_UpdateEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Odev.Models.Employee>
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
#line 2 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateEmployee.cshtml"
  
    ViewData["Title"] = "UpdateEmployee";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "611acb6b865f7f7e98e3b0235113392ea2030da62957", async() => {
                WriteLiteral("\r\n    <style>\r\n        .inputStyle {\r\n            margin-top: 10px;\r\n            margin-bottom: 10px;\r\n            justify-content: space-between;\r\n        }\r\n    </style>\r\n");
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
            <h1>UpdateEmployee</h1>
            <form method=""post"">
                <div class=""col-md- 6 inputStyle"">
                    <label>EmployeeFirstName</label>
                    <input class=""form-control"" name=""EmployeeFirstName""");
            BeginWriteAttribute("value", " value=\"", 672, "\"", 704, 1);
#nullable restore
#line 25 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateEmployee.cshtml"
WriteAttributeValue("", 680, Model.EmployeeFirstName, 680, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-6 inputStyle\">\r\n                    <label>EmployeeLastName</label>\r\n                    <input class=\"form-control\" name=\"EmployeeLastName\"");
            BeginWriteAttribute("value", " value=\"", 909, "\"", 940, 1);
#nullable restore
#line 29 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateEmployee.cshtml"
WriteAttributeValue("", 917, Model.EmployeeLastName, 917, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"inputStyle\">\r\n                    <label>EmployeeTitle</label>\r\n                    <input class=\"form-control\" name=\"EmployeeTitle\"");
            BeginWriteAttribute("value", " value=\"", 1130, "\"", 1158, 1);
#nullable restore
#line 33 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateEmployee.cshtml"
WriteAttributeValue("", 1138, Model.EmployeeTitle, 1138, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"inputStyle\">\r\n                    <label>EmployeePhone</label>\r\n                    <input class=\"form-control\" name=\"EmployeePhone\"");
            BeginWriteAttribute("value", " value=\"", 1348, "\"", 1376, 1);
#nullable restore
#line 37 "C:\Users\Viraldo\Desktop\Projects\MVC-Northwind  NoDB\MVC_Odev\MVC_Odev\Views\Update\UpdateEmployee.cshtml"
WriteAttributeValue("", 1356, Model.EmployeePhone, 1356, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-outline-warning\">Güncelle</button>\r\n            </form>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Odev.Models.Employee> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591