#pragma checksum "D:\Shopping\Shopping\Views\Order\OrderInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40aaae976ee590f8026c5e21c493bdbe93950838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderInfo), @"mvc.1.0.view", @"/Views/Order/OrderInfo.cshtml")]
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
#line 1 "D:\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Shopping\Shopping\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Shopping\Shopping\Views\_ViewImports.cshtml"
using Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40aaae976ee590f8026c5e21c493bdbe93950838", @"/Views/Order/OrderInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72a8c576c6aa4cc32a0269a8f3f285c86e50bd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderListVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<!-- Start Single-Blog-detail -->\r\n<section");
            BeginWriteAttribute("style", " style=\"", 65, "\"", 130, 3);
            WriteAttributeValue("", 73, "background-image:url(", 73, 21, true);
#nullable restore
#line 4 "D:\Shopping\Shopping\Views\Order\OrderInfo.cshtml"
WriteAttributeValue("", 94, Model.BackImageWishCheck.PhotoUrl, 94, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 128, ");", 128, 2, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"single-list\">\r\n        <div class=\"container\">\r\n            <h1");
            BeginWriteAttribute("style", " style=\"", 199, "\"", 244, 2);
            WriteAttributeValue("", 207, "color:", 207, 6, true);
#nullable restore
#line 6 "D:\Shopping\Shopping\Views\Order\OrderInfo.cshtml"
WriteAttributeValue("", 213, Model.BackImageWishCheck.Color, 213, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sifariş</h1>\r\n            <ol class=\"breadcrumb\">\r\n                <li><a");
            BeginWriteAttribute("style", " style=\"", 319, "\"", 364, 2);
            WriteAttributeValue("", 327, "color:", 327, 6, true);
#nullable restore
#line 8 "D:\Shopping\Shopping\Views\Order\OrderInfo.cshtml"
WriteAttributeValue("", 333, Model.BackImageWishCheck.Color, 333, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"index.html\">Ana Səhifə</a></li>\r\n                <li><span");
            BeginWriteAttribute("style", " style=\"", 430, "\"", 475, 2);
            WriteAttributeValue("", 438, "color:", 438, 6, true);
#nullable restore
#line 9 "D:\Shopping\Shopping\Views\Order\OrderInfo.cshtml"
WriteAttributeValue("", 444, Model.BackImageWishCheck.Color, 444, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Sifariş </span></li>
            </ol>
        </div>
    </section>
<!-- End Single-Blog-detail -->
<link href=""//cdn.datatables.net/1.11.0/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
<!----------------------------------->
<section style=""padding:4rem 0"" id=""myAccount"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""tab-menu-detail"">
                    <div id=""Order"" class=""tabcontent d-block"">
                        <h1>Sifarişlərim</h1>
                        <hr>
                        <table id=""myOrderTable"">
                            <thead>
                                <tr>
                                    <th><label>Tarix</label></th>
                                    <th><label>Sifarişin kodu</label></th>
                                    <th><label>Məbləğ</label></th>
                                    <th>Daha çox</th>
");
            WriteLiteral("                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 35 "D:\Shopping\Shopping\Views\Order\OrderInfo.cshtml"
                                 foreach (var order in Model.Orders)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td data-label=\"Tarix\">");
#nullable restore
#line 39 "D:\Shopping\Shopping\Views\Order\OrderInfo.cshtml"
                                                          Write(order.PlacedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td data-label=\"Sifarişin kodu\">");
#nullable restore
#line 40 "D:\Shopping\Shopping\Views\Order\OrderInfo.cshtml"
                                                                   Write(order.OrderCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td data-label=\"Məbləğ\">");
#nullable restore
#line 41 "D:\Shopping\Shopping\Views\Order\OrderInfo.cshtml"
                                                           Write(order.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2136, "\"", 2196, 1);
#nullable restore
#line 43 "D:\Shopping\Shopping\Views\Order\OrderInfo.cshtml"
WriteAttributeValue("", 2143, Url.Action("OrderDetail","Order",new { id=order.ID}), 2143, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ətraflı</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 46 "D:\Shopping\Shopping\Views\Order\OrderInfo.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"//cdn.datatables.net/1.11.0/js/jquery.dataTables.min.js\"></script>\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#myOrderTable\').DataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderListVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
