#pragma checksum "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c621ec9807a01a1430849e754a5a1afcfd251188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Index.cshtml", typeof(AspNetCore.Views_Shop_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c621ec9807a01a1430849e754a5a1afcfd251188", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aab7042ebd9a4d395ab334bdb4bcc8b4e7979ba", @"/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(59, 388, true);
            WriteLiteral(@"
    <main>
        <section id=""shopName"">
            <div class=""container"">
                <div class=""row"">
                    <h3>SHOP</h3>
                </div>
            </div>
        </section>
        <section id=""shoppingElements"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-9 shopLeftSide"">
");
            EndContext();
#line 18 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                         foreach (Product product in Model.Products)
                        {

#line default
#line hidden
            BeginContext(544, 126, true);
            WriteLiteral("                            <div class=\"col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement\">\r\n                                ");
            EndContext();
            BeginContext(670, 187, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "337af89af0424244adfad78d0f91fd81", async() => {
                BeginContext(742, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(743, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4bd6b0e0947648a28cad7b8e9c743649", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 771, "~/img/shop/", 771, 11, true);
#line 21 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 782, product.ProductImages.FirstOrDefault(p=>p.IsMain==true).Image, 782, 62, false);

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
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                                                               WriteLiteral(product.Id);

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
            BeginContext(857, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(891, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb1360a7fef24be4a45ad2ab6ec370c9", async() => {
                BeginContext(963, 42, true);
                WriteLiteral("\r\n                                    <h4>");
                EndContext();
                BeginContext(1006, 12, false);
#line 23 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                   Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1018, 39, true);
                WriteLiteral("</h4>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                                                               WriteLiteral(product.Id);

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
            BeginContext(1061, 38, true);
            WriteLiteral("\r\n                                <p>$");
            EndContext();
            BeginContext(1100, 13, false);
#line 25 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                               Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 142, true);
            WriteLiteral(".00</p>\r\n                                <a href=\"#\" class=\"btn btn-primary addToCart\">ADD TO CART</a>\r\n\r\n                            </div>\r\n");
            EndContext();
#line 29 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1282, 293, true);
            WriteLiteral(@"
                    </div>
                    <div class=""col-lg-3 col-md-3 col-sm-12 col-12 ShopRightSide"">
                        <div class=""shopCategories"">
                            <h6>PRODUCT CATEGORIES</h6>
                            <hr>
                            <ul>
");
            EndContext();
#line 37 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                 foreach (ProductCategory category in Model.ProductCategories)
                                {

#line default
#line hidden
            BeginContext(1706, 52, true);
            WriteLiteral("                                    <li><a href=\"#\">");
            EndContext();
            BeginContext(1759, 13, false);
#line 39 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                               Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1772, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 40 "C:\Users\Admin\Desktop\CarService Backend\EndProject\EndProject\Views\Shop\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1818, 5466, true);
            WriteLiteral(@"
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-9 col-md-9 col-sm-12 col-12 shopPagination"">
                        <ul>
                            <li><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                        </ul>
                    </div>


                </div>
            </div>
        </section>
        <section id=""shoppingElementsResponsive"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-9 shopLeftSide"">
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement"">
                            <div class=""image"">
                                <a href=""#""> <img class=""img-fluid"" src=""img/shop/hoodie_3_front.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
     ");
            WriteLiteral(@"                           <h4>FLYING NINJA</h4>
                            </a>
                            <p>$12.00</p>
                            <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
                        </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement"">
                            <div class=""image"">
                                <a href=""#""> <img class=""img-fluid"" src=""img/shop/hoodie_4_front.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
                                <h4>FLYING NINJA</h4>
                            </a>
                            <p>$12.00</p>
                            <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
                        </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement"">
                            <div class=""image"">
                                <a href=""#""> <im");
            WriteLiteral(@"g class=""img-fluid"" src=""img/shop/hoodie_5_front.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
                                <h4>FLYING NINJA</h4>
                            </a>
                            <p>$12.00</p>
                            <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
                        </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement"">
                            <div class=""image"">
                                <a href=""#""> <img class=""img-fluid"" src=""img/shop/poster_2_up.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
                                <h4>FLYING NINJA</h4>
                            </a>
                            <p>$12.00</p>
                            <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
                        </div>
                        <div class=""col-");
            WriteLiteral(@"lg-4 col-md-6 col-sm-12 col-12 shoppingElement"">
                            <div class=""image"">
                                <a href=""#""> <img class=""img-fluid"" src=""img/shop/T_5_front.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
                                <h4>FLYING NINJA</h4>
                            </a>
                            <p>$12.00</p>
                            <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
                        </div>
                        <div class=""col-lg-4 col-md-6 col-sm-12 col-12 shoppingElement   "">
                            <div class=""image"">
                                <a href=""#""> <img class=""img-fluid"" src=""img/shop/T_7_front.jpg"" alt=""""></a>
                            </div>
                            <a href=""#"">
                                <h4>FLYING NINJA</h4>
                            </a>
                            <p>$12.00</p>
                    ");
            WriteLiteral(@"        <a href=""#"" class=""btn btn-primary addToCart"">ADD TO CART</a>
                        </div>
                    </div>
                    <div class=""col-lg-9 col-md-9 col-sm-12 col-12 shopPagination"">
                        <ul>
                            <li><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                        </ul>
                    </div>
                    <div class=""col-lg-3 col-md-12 col-sm-12 col-12 ShopRightSide"">
                        <div class=""shopCategories"">
                            <h6>PRODUCT CATEGORIES</h6>
                            <hr>
                            <ul>
                                <li><a href=""#"">ALBUMS</a></li>
                                <li><a href=""#"">CLOTHING</a></li>
                                <li><a href=""#"">HOODIES</a></li>
                                <li><a href=""#"">MUSIC</a></li>
                         ");
            WriteLiteral(@"       <li><a href=""#"">POSTERS</a></li>
                                <li><a href=""#"">SINGLES</a></li>
                                <li><a href=""#"">T-SHIRTS</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591