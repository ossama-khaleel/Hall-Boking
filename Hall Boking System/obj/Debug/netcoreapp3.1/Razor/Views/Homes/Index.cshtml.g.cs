#pragma checksum "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Homes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126e02ba890dfb9f9d9cac1f5e4c1f46cb6d7ed4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Homes_Index), @"mvc.1.0.view", @"/Views/Homes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126e02ba890dfb9f9d9cac1f5e4c1f46cb6d7ed4", @"/Views/Homes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a7fbca9e00289477df31c87863086b52fd2c85d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Homes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hall_Boking_System.Models.Home>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Homes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminDashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Homes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HomeImage1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Homes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HomeImage2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Homes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HomeImage3));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Homes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n              <img");
            BeginWriteAttribute("src", " src=", 746, "", 793, 1);
#nullable restore
#line 32 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Homes\Index.cshtml"
WriteAttributeValue("", 751, Url.Content("~/Images/"+@item.HomeImage1), 751, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius:10%;\" width=\"150\" height=\"150\" />\r\n            </td>\r\n            <td>\r\n              <img");
            BeginWriteAttribute("src", " src=", 905, "", 952, 1);
#nullable restore
#line 35 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Homes\Index.cshtml"
WriteAttributeValue("", 910, Url.Content("~/Images/"+@item.HomeImage2), 910, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius:10%;\" width=\"150\" height=\"150\" />\r\n            </td>\r\n            <td>\r\n              <img");
            BeginWriteAttribute("src", " src=", 1064, "", 1111, 1);
#nullable restore
#line 38 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Homes\Index.cshtml"
WriteAttributeValue("", 1069, Url.Content("~/Images/"+@item.HomeImage3), 1069, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius:10%;\" width=\"150\" height=\"150\" />\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "126e02ba890dfb9f9d9cac1f5e4c1f46cb6d7ed47195", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Homes\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\OSSAMA\source\repos\Hall Boking System\Hall Boking System\Views\Homes\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hall_Boking_System.Models.Home>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
