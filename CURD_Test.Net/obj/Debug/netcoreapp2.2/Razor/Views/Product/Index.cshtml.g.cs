#pragma checksum "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd9770fed892d2d1f77db757abb8c52479af24f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\_ViewImports.cshtml"
using CURD_Test.Net;

#line default
#line hidden
#line 2 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\_ViewImports.cshtml"
using CURD_Test.Net.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dd9770fed892d2d1f77db757abb8c52479af24f", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c071f48bd98eea4d7f6a0598f5db11dbf3e32e81", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CURD_Test.Net.Models.ProductModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dd9770fed892d2d1f77db757abb8c52479af24f3839", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 104, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Product ID\r\n");
            EndContext();
            BeginContext(330, 67, true);
            WriteLiteral("            </th>\r\n            <th>\r\n                Product Name\r\n");
            EndContext();
            BeginContext(460, 60, true);
            WriteLiteral("            </th>\r\n            <th>\r\n                Brand\r\n");
            EndContext();
            BeginContext(584, 63, true);
            WriteLiteral("            </th>\r\n            <th>\r\n                Price($)\r\n");
            EndContext();
            BeginContext(711, 73, true);
            WriteLiteral("            </th>\r\n            <th>\r\n                Remaining products\r\n");
            EndContext();
            BeginContext(857, 76, true);
            WriteLiteral("            </th>\r\n            <th>\r\n                Last Updata products \r\n");
            EndContext();
            BeginContext(1006, 84, true);
            WriteLiteral("            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1122, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1171, 38, false);
#line 46 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item._id));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1265, 39, false);
#line 49 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1360, 40, false);
#line 52 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.brand));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1456, 40, false);
#line 55 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 58, true);
            WriteLiteral(" US\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1555, 49, false);
#line 58 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.countOfProduct));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1660, 53, false);
#line 61 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastUpdateDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1769, 53, false);
#line 64 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item._id }));

#line default
#line hidden
            EndContext();
            BeginContext(1822, 19, true);
            WriteLiteral(" \r\n                ");
            EndContext();
            BeginContext(1842, 58, false);
#line 65 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item._id }));

#line default
#line hidden
            EndContext();
            BeginContext(1900, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1919, 56, false);
#line 66 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item._id }));

#line default
#line hidden
            EndContext();
            BeginContext(1975, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "C:\Users\chokc\source\repos\CURD_Test.Net\CURD_Test.Net\Views\Product\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2014, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CURD_Test.Net.Models.ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
