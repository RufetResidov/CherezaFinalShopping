#pragma checksum "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95c497af6362f50b2ac8fcd2d2ac4cbb211329ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Orders_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Orders/Details.cshtml")]
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
#line 1 "D:\Shopping\Shopping\Areas\Admin\Views\_ViewImports.cshtml"
using Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Shopping\Shopping\Areas\Admin\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Shopping\Shopping\Areas\Admin\Views\_ViewImports.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Shopping\Shopping\Areas\Admin\Views\_ViewImports.cshtml"
using Shopping.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Shopping\Shopping\Areas\Admin\Views\_ViewImports.cshtml"
using Shopping.Areas.Admin.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Shopping\Shopping\Areas\Admin\Views\_ViewImports.cshtml"
using Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c497af6362f50b2ac8fcd2d2ac4cbb211329ba", @"/Areas/Admin/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20b1afdf0ccb701c56d512db68b390d12dc56d0a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeliveryChanges));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeliveryChanges));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlacedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlacedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 72 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 77 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
             foreach (var item in ViewData["product"] as IEnumerable<Entities.Product>)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul>\r\n");
#nullable restore
#line 80 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
                     foreach (var models in Model.OrderItems.Where(x => x.ProductID == item.ID))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 83 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -- ");
#nullable restore
#line 83 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
                                      Write(models.Quantity *100);

#line default
#line hidden
#nullable disable
            WriteLiteral(" qram</li>\r\n");
#nullable restore
#line 84 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
#nullable restore
#line 87 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n");
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95c497af6362f50b2ac8fcd2d2ac4cbb211329ba12099", async() => {
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
#line 128 "D:\Shopping\Shopping\Areas\Admin\Views\Orders\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95c497af6362f50b2ac8fcd2d2ac4cbb211329ba14224", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
