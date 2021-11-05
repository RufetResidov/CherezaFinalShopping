#pragma checksum "D:\Shopping\Shopping\Views\Blog\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "552f7c392b64ddc1a7e878a568af5f3bab1980a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_List), @"mvc.1.0.view", @"/Views/Blog/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"552f7c392b64ddc1a7e878a568af5f3bab1980a4", @"/Views/Blog/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72a8c576c6aa4cc32a0269a8f3f285c86e50bd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVm>
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
#line 1 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
  
    ViewData["Title"] = "Bloqlar";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <style>\r\n        .disabled {\r\n            pointer-events: none;\r\n        }\r\n    </style>\r\n<!-- Start Single-Blog-List -->\r\n<section");
            BeginWriteAttribute("style", " style=\"", 235, "\"", 296, 3);
            WriteAttributeValue("", 243, "background-image:url(", 243, 21, true);
#nullable restore
#line 12 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 264, Model.BackImageBlogs.PhotoUrl, 264, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 294, ");", 294, 2, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"single-list\">\r\n    <div class=\"container\">\r\n        <h1");
            BeginWriteAttribute("style", " style=\"", 357, "\"", 398, 2);
            WriteAttributeValue("", 365, "color:", 365, 6, true);
#nullable restore
#line 14 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 371, Model.BackImageBlogs.Color, 371, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Bloqlar</h1>\r\n        <ol class=\"breadcrumb\">\r\n            <li><a");
            BeginWriteAttribute("style", " style=\"", 465, "\"", 506, 2);
            WriteAttributeValue("", 473, "color:", 473, 6, true);
#nullable restore
#line 16 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 479, Model.BackImageBlogs.Color, 479, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/\">Ana səhifə</a></li>\r\n            <li><span");
            BeginWriteAttribute("style", " style=\"", 559, "\"", 600, 2);
            WriteAttributeValue("", 567, "color:", 567, 6, true);
#nullable restore
#line 17 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 573, Model.BackImageBlogs.Color, 573, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Bloqlar </span></li>
        </ol>
    </div>
</section>
<!-- End Single-Blog-List -->
<!----------------------------------->
<!-- Start Single-List -->
<section id=""blog-list"">
    <div class=""container-fluid"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-8"">
                <div class=""row"">
");
#nullable restore
#line 29 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                     foreach (var blogList in Model.BlogList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-sm-6 col-lg-6 col-xxl-3 col-xl-4 col-12 \">\r\n                            <div class=\"blogCard \">\r\n                                <div class=\"thumb\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1267, "\"", 1324, 1);
#nullable restore
#line 34 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 1274, Url.Action("Detail","Blog",new { id=blogList.ID}), 1274, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1386, "\"", 1410, 1);
#nullable restore
#line 35 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 1392, blogList.PhotoUrl, 1392, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product\" />\r\n                                    </a>\r\n                                    <span class=\"badges\">\r\n                                        <span class=\"time\">");
#nullable restore
#line 38 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                                      Write(blogList.PublishDate.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </span>\r\n                                    <span class=\"badges1\">\r\n                                        <span class=\"category\">");
#nullable restore
#line 41 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                                          Write(blogList.BlogCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </span>\r\n                                </div>\r\n                                <div class=\"content\">\r\n                                    <h4>");
#nullable restore
#line 45 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                   Write(blogList.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 46 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                         if (blogList.Title != null && blogList.Title.Length > 60 && blogList.Title.Length > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 48 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                             Write(Html.Raw(blogList.Title.Substring(0, 60)));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</span>\r\n");
#nullable restore
#line 49 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 52 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                             Write(Html.Raw(blogList.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 53 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 2624, "\"", 2656, 2);
            WriteAttributeValue("", 2631, "/Blog/Detail/", 2631, 13, true);
#nullable restore
#line 54 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 2644, blogList.ID, 2644, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Daha ətraflı <i class=\"fas fa-chevron-right\"></i></a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 58 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <!--  Pagination Area Start -->
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""bottom-paginate"">
                            <ul class=""pagination"">
                                <li class=""page-item"">
                                    <a");
            BeginWriteAttribute("class", " class=\"", 3199, "\"", 3261, 2);
            WriteAttributeValue("", 3207, "page-link", 3207, 9, true);
#nullable restore
#line 66 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue(" ", 3216, Model.Pager.CurrentPage==1? "disabled":"", 3217, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3262, "\"", 3335, 1);
#nullable restore
#line 66 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 3269, Url.Action("List","Blog",new { pageNo=Model.Pager.CurrentPage-1}), 3269, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i class=\"fas fa-long-arrow-alt-left\"></i>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 70 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                 for (int mypage = Model.Pager.StartPage; mypage < Model.Pager.EndPage + 1; mypage++)
                                {
                                    var active = mypage == Model.Pager.CurrentPage ? "active" : string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\"><a");
            BeginWriteAttribute("class", " class=\"", 3829, "\"", 3854, 2);
            WriteAttributeValue("", 3837, "page-link", 3837, 9, true);
#nullable restore
#line 73 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue(" ", 3846, active, 3847, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 3855, "\"", 3909, 1);
#nullable restore
#line 73 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 3862, Url.Action("List","Blog",new { pageNo=mypage}), 3862, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                                                                                                                         Write(mypage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 74 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a");
            BeginWriteAttribute("class", " class=\"", 4058, "\"", 4138, 2);
            WriteAttributeValue("", 4066, "page-link", 4066, 9, true);
#nullable restore
#line 76 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue(" ", 4075, Model.Pager.CurrentPage==Model.Pager.EndPage? "disabled":"", 4076, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 4139, "\"", 4212, 1);
#nullable restore
#line 76 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 4146, Url.Action("List","Blog",new { pageNo=Model.Pager.CurrentPage+1}), 4146, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                        <i class=""fas fa-long-arrow-alt-right""></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!--  Pagination Area End -->
            </div>
            <div class=""col-md-7 col-lg-3"">
                <div class=""blog-widget"">
                    <h3 class=""blog-widget-title"">Önə çıxanlar</h3>
");
#nullable restore
#line 89 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                     foreach (var popBlog in Model.BlogPop)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul class=\"blog-widget-feed\">\r\n                            <li>\r\n                                <a class=\"blog-widget-media\"");
            BeginWriteAttribute("href", " href=\"", 4958, "\"", 5014, 1);
#nullable restore
#line 93 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 4965, Url.Action("Detail","Blog",new { id=popBlog.ID}), 4965, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 5058, "\"", 5081, 1);
#nullable restore
#line 94 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 5064, popBlog.PhotoUrl, 5064, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                         alt=\"blog-widget\">\r\n                                </a>\r\n                                <div class=\"blog-widget-text\">\r\n                                    <h6><a");
            BeginWriteAttribute("href", " href=\"", 5289, "\"", 5320, 2);
            WriteAttributeValue("", 5296, "/Blog/Detail/", 5296, 13, true);
#nullable restore
#line 98 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 5309, popBlog.ID, 5309, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 98 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                                                      Write(popBlog.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h6>\r\n                                    <p>");
#nullable restore
#line 99 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                  Write(popBlog.PublishDate.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </li>\r\n                        </ul>\r\n");
#nullable restore
#line 103 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"blog-widget\">\r\n                    <h3 class=\"blog-widget-title\">Kategoriyalar</h3>\r\n                    <ul class=\"blog-widget-category\">\r\n");
#nullable restore
#line 110 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                         foreach (var topCat in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 5891, "\"", 5944, 1);
#nullable restore
#line 112 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
WriteAttributeValue("", 5898, Url.Action("List","Blog",new { id=topCat.ID}), 5898, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 112 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                                                                    Write(topCat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 112 "D:\Shopping\Shopping\Views\Blog\List.cshtml"
                                                                                                        Write(topCat.Blogs.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\r\n");
#nullable restore
#line 113 "D:\Shopping\Shopping\Views\Blog\List.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
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
<!-- End Single-List -->
<!----------------------------------->
<!-- Start DeliveryInfo -->
<section id=""deliveryinfo"">
    <div class=""container "">
        <div class=""row "">
            <div class=""col-12 col-md-6 col-lg-3"">
                <div class=""box"">
                  ");
            WriteLiteral("  <div class=\"text\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "552f7c392b64ddc1a7e878a568af5f3bab1980a422406", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "552f7c392b64ddc1a7e878a568af5f3bab1980a423871", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "552f7c392b64ddc1a7e878a568af5f3bab1980a425384", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "552f7c392b64ddc1a7e878a568af5f3bab1980a426844", async() => {
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

<!----------------------------------->
<!-- End DeliveryInfo -->
");
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
