#pragma checksum "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fc196c3f81a243de6f7bc654a00c43104f4f7f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Detail), @"mvc.1.0.view", @"/Views/Gallery/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gallery/Detail.cshtml", typeof(AspNetCore.Views_Gallery_Detail))]
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
#line 1 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\_ViewImports.cshtml"
using EndProject.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\_ViewImports.cshtml"
using EndProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fc196c3f81a243de6f7bc654a00c43104f4f7f4", @"/Views/Gallery/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aab7042ebd9a4d395ab334bdb4bcc8b4e7979ba", @"/_ViewImports.cshtml")]
    public class Views_Gallery_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GalleryVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(60, 132, true);
            WriteLiteral("\r\n<main>\r\n    <section id=\"galleryDetailName\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <h3>");
            EndContext();
            BeginContext(193, 19, false);
#line 10 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml"
               Write(Model.Servicee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(212, 239, true);
            WriteLiteral("</h3>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section id=\"galleryDetail\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-6 col-md-6 col-sm-6 col-6 leftcolumnGallery\">\r\n");
            EndContext();
#line 18 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml"
                     foreach (ServiceImage image in Model.ServiceImages)
                    {

#line default
#line hidden
            BeginContext(548, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(572, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2cf1ad2129942dca3cc5b67b43f107e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 600, "~/img/services/", 600, 15, true);
#line 20 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml"
AddHtmlAttributeValue("", 615, image.Image, 615, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(636, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(661, 231, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-lg-6 col-md-6 col-sm-6 col-6 rightcolumnGallery\">\r\n                    <h3>BRIEF DESCRIPTION</h3>\r\n                    <hr>\r\n                    <p>\r\n                       ");
            EndContext();
            BeginContext(893, 26, false);
#line 28 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml"
                  Write(Model.Servicee.Description);

#line default
#line hidden
            EndContext();
            BeginContext(919, 318, true);
            WriteLiteral(@"
                    </p>
                    <h3>AT A GLANCE</h3>
                    <hr>
                    <table class=""table table-striped"">
                        <tbody>
                            <tr>
                                <td>Front Brakes Repair</td>
                                <td>");
            EndContext();
            BeginContext(1238, 32, false);
#line 36 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml"
                               Write(Model.Servicee.FrontBrakesRepair);

#line default
#line hidden
            EndContext();
            BeginContext(1270, 174, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Rear Brakes Repair\t</td>\r\n                                <td>");
            EndContext();
            BeginContext(1445, 31, false);
#line 40 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml"
                               Write(Model.Servicee.RearBrakesRepair);

#line default
#line hidden
            EndContext();
            BeginContext(1476, 171, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Rear Brake Shoes</td>\r\n                                <td>");
            EndContext();
            BeginContext(1648, 30, false);
#line 44 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml"
                               Write(Model.Servicee.RearBrakesShoes);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 159, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Axle</td>\r\n                                <td>");
            EndContext();
            BeginContext(1838, 19, false);
#line 48 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml"
                               Write(Model.Servicee.Axle);

#line default
#line hidden
            EndContext();
            BeginContext(1857, 178, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>Starters / Alternators\t</td>\r\n                                <td>");
            EndContext();
            BeginContext(2036, 34, false);
#line 52 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Detail.cshtml"
                               Write(Model.Servicee.StartersAlternators);

#line default
#line hidden
            EndContext();
            BeginContext(2070, 1231, true);
            WriteLiteral(@"</td>
                            </tr>
                        </tbody>
                    </table>
                    <h3>SCOPE OF WORK</h3>
                    <hr>
                    <p>
                        We offer full range of garage services to vehicle owners in Tucson. Our professionals know
                        how to handle a wide range of car services. We can handle any problem on both foreign and
                        domestic vehicles.
                    </p>
                    <ul>
                        <li><i class=""fas fa-check""></i>We make auto repair and maintenance more convenient for you</li>
                        <li><i class=""fas fa-check""></i>We are a friendly, helpful and professional group of people</li>
                        <li><i class=""fas fa-check""></i>Our professionals know how to handle a wide range of car services</li>
                        <li><i class=""fas fa-check""></i>We get the job done right — the first time</li>
                   ");
            WriteLiteral("     <li><i class=\"fas fa-check\"></i>Same day service for most repairs and maintenance</li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GalleryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
