#pragma checksum "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30cad46f543232e2591bee693a071c259ff2564f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contactus_Index), @"mvc.1.0.view", @"/Views/Contactus/Index.cshtml")]
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
#line 1 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\_ViewImports.cshtml"
using Hall_Boking_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\_ViewImports.cshtml"
using Hall_Boking_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30cad46f543232e2591bee693a071c259ff2564f", @"/Views/Contactus/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a7fbca9e00289477df31c87863086b52fd2c85d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contactus_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hall_Boking_System.Models.Contactu>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminDashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-striped\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Home.HomeImage1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Contactus\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hall_Boking_System.Models.Contactu>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
