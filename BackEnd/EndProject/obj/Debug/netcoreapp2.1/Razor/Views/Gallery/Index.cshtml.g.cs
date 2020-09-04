#pragma checksum "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf627fa125bf83b9cdf5e3d7a3f2e86b6c283a8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Index), @"mvc.1.0.view", @"/Views/Gallery/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gallery/Index.cshtml", typeof(AspNetCore.Views_Gallery_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf627fa125bf83b9cdf5e3d7a3f2e86b6c283a8a", @"/Views/Gallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aab7042ebd9a4d395ab334bdb4bcc8b4e7979ba", @"/_ViewImports.cshtml")]
    public class Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GalleryVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gallery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(59, 528, true);
            WriteLiteral(@"
    <main>
        <section id=""galleryName"">
            <div class=""container"">
                <div class=""row"">
                    <h3>RECENT GALLERIES</h3>
                </div>
            </div>
        </section>
        <section id=""gallery"">
            <div class=""container"">
                <div class=""row galleryNameList"">
                    <div class=""col-lg-12 col-md-12 col-sm-12 col-12"">
                        <ul>
                            <li data-id=""all"" class=""selected"">All</li>
");
            EndContext();
#line 20 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml"
                             foreach (ServiceCategory category in @Model.ServiceCategories)
                            {

#line default
#line hidden
            BeginContext(711, 45, true);
            WriteLiteral("                                <li data-id=\"");
            EndContext();
            BeginContext(757, 23, false);
#line 22 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml"
                                        Write(category.Name.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(780, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(783, 13, false);
#line 22 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml"
                                                                  Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(796, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 23 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(834, 130, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n\r\n                </div>\r\n                <div class=\"row galleries\">\r\n");
            EndContext();
#line 29 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml"
                     foreach (Service service in Model.Services)
                    {

#line default
#line hidden
            BeginContext(1053, 89, true);
            WriteLiteral("                        <div class=\"col-lg-3 col-md-3 col-sm-6 col-12 gallery \" data-id=\"");
            EndContext();
            BeginContext(1143, 38, false);
#line 31 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml"
                                                                                    Write(service.ServiceCategory.Name.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(1181, 54, true);
            WriteLiteral("\">\r\n                            <img class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1235, "\"", 1316, 2);
            WriteAttributeValue("", 1241, "img/services/", 1241, 13, true);
#line 32 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 1254, service.ServiceImages.FirstOrDefault(s=>s.IsMain==true).Image, 1254, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1317, 80, true);
            WriteLiteral(" alt=\"\">\r\n                            <div>\r\n                                <p>");
            EndContext();
            BeginContext(1398, 12, false);
#line 34 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml"
                              Write(service.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1410, 38, true);
            WriteLiteral("</p>\r\n                                ");
            EndContext();
            BeginContext(1448, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecc8497f86d54d53982fc1b7f41c5e0d", async() => {
                BeginContext(1547, 9, true);
                WriteLiteral("READ MORE");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml"
                                                                                                          WriteLiteral(service.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1560, 70, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 38 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Gallery\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1653, 101, true);
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n            </div>\r\n        </section>\r\n    </main>\r\n");
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
