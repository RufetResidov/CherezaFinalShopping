#pragma checksum "D:\Shopping\Shopping\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142bc1392673f6977fd12264dbddc8be1d979ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"142bc1392673f6977fd12264dbddc8be1d979ab6", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72a8c576c6aa4cc32a0269a8f3f285c86e50bd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/photo/info1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/photo/info2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/photo/info3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/photo/info4.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Bloq";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Start Single-Blog-detail -->\r\n<section");
            BeginWriteAttribute("style", " style=\"", 140, "\"", 201, 3);
            WriteAttributeValue("", 148, "background-image:url(", 148, 21, true);
#nullable restore
#line 7 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 169, Model.BackImageBlogs.PhotoUrl, 169, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 199, ");", 199, 2, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"single-list\">\r\n    <div class=\"container\">\r\n        <h1");
            BeginWriteAttribute("style", " style=\"", 262, "\"", 303, 2);
            WriteAttributeValue("", 270, "color:", 270, 6, true);
#nullable restore
#line 9 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 276, Model.BackImageBlogs.Color, 276, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Bloq</h1>\r\n        <ol class=\"breadcrumb\">\r\n            <li><a");
            BeginWriteAttribute("style", " style=\"", 367, "\"", 408, 2);
            WriteAttributeValue("", 375, "color:", 375, 6, true);
#nullable restore
#line 11 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 381, Model.BackImageBlogs.Color, 381, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/\">Ana Səhifə</a></li>\r\n            <li><span");
            BeginWriteAttribute("style", " style=\"", 461, "\"", 502, 2);
            WriteAttributeValue("", 469, "color:", 469, 6, true);
#nullable restore
#line 12 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 475, Model.BackImageBlogs.Color, 475, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Bloq </span></li>
        </ol>
    </div>
</section>
<!-- End Single-Blog-detail -->
<!----------------------------------->
<!-- Start Single-details -->
<section id=""blog-details"">
    <div class=""container-fluid"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-8"">
                <div class=""row"">

                    <div class=""blogCard "">
                        <div class=""thumb"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 973, "\"", 1013, 2);
            WriteAttributeValue("", 980, "/Blog/Detail/", 980, 13, true);
#nullable restore
#line 27 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 993, Model.BlogDetail.ID, 993, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1067, "\"", 1099, 1);
#nullable restore
#line 28 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 1073, Model.BlogDetail.PhotoUrl, 1073, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product\" />\r\n                            </a>\r\n                        </div>\r\n                        <div class=\"content\">\r\n                            <h2>");
#nullable restore
#line 32 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                           Write(Model.BlogDetail.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <span> <i class=\"fas fa-calendar-alt\"></i> ");
#nullable restore
#line 33 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                                                                  Write(Model.BlogDetail.PublishDate.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <h6>");
#nullable restore
#line 34 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                           Write(Model.BlogDetail.BlogCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <p>\r\n                                    ");
#nullable restore
#line 36 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                               Write(Html.Raw(Model.BlogDetail.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-7 col-lg-4"">
                <div class=""blog-widget"">
                    <h3 class=""blog-widget-title"">Önə Çıxanlar</h3>
");
#nullable restore
#line 45 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                     foreach (var popBlog in Model.BlogPop)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul class=\"blog-widget-feed\">\r\n                            <li>\r\n                                <a class=\"blog-widget-media\"");
            BeginWriteAttribute("href", " href=\"", 2134, "\"", 2165, 2);
            WriteAttributeValue("", 2141, "/Blog/Detail/", 2141, 13, true);
#nullable restore
#line 49 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 2154, popBlog.ID, 2154, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2209, "\"", 2232, 1);
#nullable restore
#line 50 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 2215, popBlog.PhotoUrl, 2215, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                         alt=\"blog-widget\">\r\n                                </a>\r\n                                <div class=\"blog-widget-text\">\r\n                                    <h6><a");
            BeginWriteAttribute("href", " href=\"", 2440, "\"", 2471, 2);
            WriteAttributeValue("", 2447, "/Blog/Detail/", 2447, 13, true);
#nullable restore
#line 54 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 2460, popBlog.ID, 2460, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                                                                      Write(popBlog.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h6>\r\n                                    <p>");
#nullable restore
#line 55 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                                  Write(popBlog.PublishDate.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </li>\r\n                        </ul>\r\n");
#nullable restore
#line 59 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"blog-widget\">\r\n                    <h3 class=\"blog-widget-title\">Kategoriyalar</h3>\r\n                    <ul class=\"blog-widget-category\">\r\n");
#nullable restore
#line 64 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                         foreach (var topCat in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3038, "\"", 3091, 1);
#nullable restore
#line 66 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 3045, Url.Action("List","Blog",new { id=topCat.ID}), 3045, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                                                                                    Write(topCat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 66 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                                                                                                        Write(topCat.Blogs.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\r\n");
#nullable restore
#line 67 "D:\Shopping\Shopping\Views\Blog\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </ul>
                </div>
                <div class=""blog-widget"">
                    <h3 class=""blog-widget-title"">Bizi izləyin</h3>
                    <ul class=""blog-widget-social"">
                        <li><a href=""#""><i class=""fab fa-facebook""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-telegram""></i></a></li>
                        <li><a href=""#""><i class=""fab fa-whatsapp""></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End Single-details -->
<!----------------------------------->
<!-- Start DeliveryInfo -->
<section id=""deliveryinfo"">
    <div class=""container "">
        <div class=""row "">
            <div class=""col-12 col-md-6 col-lg-3"">
                <div class=""box"">
             ");
            WriteLiteral("       <div class=\"text\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "142bc1392673f6977fd12264dbddc8be1d979ab615696", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <h4>Online alışveriş</h4>
                        <p>Mağazada alış-veriş etmək çox asandır.</p>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-6 col-lg-3"">
                <div class=""box"">
                    <div class=""text"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "142bc1392673f6977fd12264dbddc8be1d979ab617161", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <h4>Təhlükəsiz alış-veriş</h4>
                        <p>
                            təhlükəsiz ödəmə vasitəsi
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-6 col-lg-3"">
                <div class=""box"">
                    <div class=""text"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "142bc1392673f6977fd12264dbddc8be1d979ab618674", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <h4>Pulsuz çatdırılma</h4>
                        <p>59 manat üzəri çatdırılma pulsuz</p>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-6 col-lg-3"">
                <div class=""box"">
                    <div class=""text"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "142bc1392673f6977fd12264dbddc8be1d979ab620134", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <h4>Təbii məhsul</h4>
                        <p>100% təbii məhsul</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- End DeliveryInfo -->
<!----------------------------------->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Services.BlogService BlogService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
