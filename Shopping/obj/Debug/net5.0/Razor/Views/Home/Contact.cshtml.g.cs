#pragma checksum "D:\Shopping\Shopping\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6781cc70203a468ae8629922a8c63c7c8cf5372b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6781cc70203a468ae8629922a8c63c7c8cf5372b", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72a8c576c6aa4cc32a0269a8f3f285c86e50bd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Adınız"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "tel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Telefon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 157px; padding-top: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Mesaj"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Əlaqə";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<!-- Start Single-Contact -->\r\n<section");
            BeginWriteAttribute("style", " style=\"", 100, "\"", 161, 3);
            WriteAttributeValue("", 108, "background-image:url(", 108, 21, true);
#nullable restore
#line 7 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
WriteAttributeValue("", 129, Model.BackImageAbout.PhotoUrl, 129, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 159, ");", 159, 2, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"single-list\">\r\n    <div class=\"container\">\r\n        <h1");
            BeginWriteAttribute("style", " style=\"", 222, "\"", 263, 2);
            WriteAttributeValue("", 230, "color:", 230, 6, true);
#nullable restore
#line 9 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
WriteAttributeValue("", 236, Model.BackImageAbout.Color, 236, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Əlaqə</h1>\r\n        <ol class=\"breadcrumb\">\r\n            <li><a");
            BeginWriteAttribute("style", " style=\"", 328, "\"", 369, 2);
            WriteAttributeValue("", 336, "color:", 336, 6, true);
#nullable restore
#line 11 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
WriteAttributeValue("", 342, Model.BackImageAbout.Color, 342, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"/\">Ana səhifə</a></li>\r\n            <li><span");
            BeginWriteAttribute("style", " style=\"", 422, "\"", 463, 2);
            WriteAttributeValue("", 430, "color:", 430, 6, true);
#nullable restore
#line 12 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
WriteAttributeValue("", 436, Model.BackImageAbout.Color, 436, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Əlaqə</span></li>\r\n        </ol>\r\n    </div>\r\n</section>\r\n<!-- End Single-Contact -->\r\n<!----------------------------------->\r\n<!-- Start Social-Contact -->\r\n<section id=\"social-contact\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 22 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
             foreach (var cont in Model.ContactSection2s)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4 m-auto\">\r\n                    <div class=\"contact-card\">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 914, "\"", 932, 1);
#nullable restore
#line 26 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
WriteAttributeValue("", 922, cont.Icon, 922, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                        <h4>");
#nullable restore
#line 27 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
                       Write(cont.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>\r\n                            <a href=\"#\">");
#nullable restore
#line 29 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
                                   Write(cont.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 33 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<!-- End Social-Contact -->
<!----------------------------------->
<!-- Start DeliveryInfo -->
<section id=""deliveryinfoContact"">
    <div class=""container "">
        <div class=""row "">
            <div class=""col-12 col-md-6 col-lg-3"">
                <div class=""box"">
                    <div class=""text"">
                        <i style=""display: block;"" class=""fas fa-shopping-basket""></i>
                        <h4>Online alışveriş</h4>
                        <p>Mağazada alış-veriş etmək çox asandır.</p>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-6 col-lg-3"">
                <div class=""box"">
                    <div class=""text"">
                        <i style=""display: block;"" class=""fab fa-expeditedssl""></i>
                        <h4>Təhlükəsiz ödəmə</h4>
                        <p>Capped at $39 per order</p>
                    </div>
                </div>
            ");
            WriteLiteral(@"</div>
            <div class=""col-12 col-md-6 col-lg-3"">
                <div class=""box"">
                    <div class=""text"">
                        <i style=""display: block;"" class=""fas fa-shipping-fast""></i>
                        <h4>Pulsuz çatdırılma</h4>
                        <p>59 manat üzəri çatdırılma pulsuz</p>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-6 col-lg-3"">
                <div class=""box"">
                    <div class=""text"">
                        <i style=""display: block;"" class=""fab fa-pagelines""></i>
                        <h4>Təbii məhsul</h4>
                        <p>100% təbii məhsul</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End DeliveryInfo -->
<!----------------------------------->
<!-- Start Contact-message -->
<section id=""contact-message"">
    <div class=""container"">
        <div class=""row"">
         ");
            WriteLiteral("   <div class=\"col-lg-6 col-md-12 col-sm-12 col-12\">\r\n                <div class=\"contact-map\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3339, "\"", 3376, 1);
#nullable restore
#line 90 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
WriteAttributeValue("", 3345, Model.ContactSection4.PhotoUrl, 3345, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3377, "\"", 3383, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 col-md-12 col-sm-12 col-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6781cc70203a468ae8629922a8c63c7c8cf5372b14295", async() => {
                WriteLiteral("\r\n                    <h4>Məlumatları daxil edin.</h4>\r\n");
#nullable restore
#line 96 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
                     if (TempData["Success"] != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p class=\"alert alert-success\">");
#nullable restore
#line 98 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
                                                  Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 99 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group  \">\r\n                        <div class=\"form-input-group \">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6781cc70203a468ae8629922a8c63c7c8cf5372b15485", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 102 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Fullname);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <i class=\"fas fa-user\"></i>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group  \">\r\n                        <div class=\"form-input-group \">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6781cc70203a468ae8629922a8c63c7c8cf5372b17598", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 108 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <i class=\"fas fa-envelope\"></i>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group \">\r\n                        <div class=\"form-input-group \">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6781cc70203a468ae8629922a8c63c7c8cf5372b19711", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 114 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PhoneNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <i class=\"fas fa-phone\"></i>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-input-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6781cc70203a468ae8629922a8c63c7c8cf5372b21767", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 119 "D:\Shopping\Shopping\Views\Home\Contact.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <i class=""fas fa-comments""></i>
                    </div>
                    <button type=""submit"" class=""form-btn"">
                        <i class=""fas fa-envelope""></i>
                        <span>Mesaj göndər</span>
                    </button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- End Contact-message -->\r\n<!----------------------------------->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
