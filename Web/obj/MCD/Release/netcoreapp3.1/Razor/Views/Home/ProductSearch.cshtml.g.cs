#pragma checksum "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66eedde7f3853200f921d3a10f96dd96b22583a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductSearch), @"mvc.1.0.view", @"/Views/Home/ProductSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ProductSearch.cshtml", typeof(AspNetCore.Views_Home_ProductSearch))]
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
#line 1 "F:\ECommercePOC\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "F:\ECommercePOC\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66eedde7f3853200f921d3a10f96dd96b22583a0", @"/Views/Home/ProductSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
  
    Layout = "_CommonLayout";

#line default
#line hidden
#line 5 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(114, 186, true);
            WriteLiteral("\r\n<div class=\"row-side\">\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <h2 class=\"text-muted\">\"");
            EndContext();
            BeginContext(301, 29, false);
#line 15 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                                   Write(ViewData["ProductSearchName"]);

#line default
#line hidden
            EndContext();
            BeginContext(330, 156, true);
            WriteLiteral("\" search result</h2>\r\n                <hr />\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" style=\"margin-top: 8px;\"> <!-- main content -->\r\n");
            EndContext();
#line 20 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
             if (Model.Count() > 0)
            {
                

#line default
#line hidden
#line 22 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                 foreach (var product in Model)
                {

#line default
#line hidden
            BeginContext(606, 178, true);
            WriteLiteral("                    <div class=\"col-md-6 col-lg-4 col-xl-3\">\r\n                        <div class=\"card\">\r\n                            <center>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 784, "\"", 816, 2);
            WriteAttributeValue("", 791, "/Home/Product/", 791, 14, true);
#line 27 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
WriteAttributeValue("", 805, product.Id, 805, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(817, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 28 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                                     if (product.ProductImage != null)
                                    {

#line default
#line hidden
            BeginContext(931, 75, true);
            WriteLiteral("                                        <img class=\"card-img-top img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1006, "\"", 1033, 1);
#line 30 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
WriteAttributeValue("", 1012, product.ProductImage, 1012, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1034, "\"", 1053, 1);
#line 30 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
WriteAttributeValue("", 1040, product.Name, 1040, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1054, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 31 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(1179, 109, true);
            WriteLiteral("                                        <img class=\"card-img-top img-fluid\" src=\"/images/system/no-image.png\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 1288, "\"", 1307, 1);
#line 34 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
WriteAttributeValue("", 1294, product.Name, 1294, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1308, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 35 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1352, 165, true);
            WriteLiteral("                                </a>\r\n                            </center>\r\n                            <div class=\"card-block\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1517, "\"", 1549, 2);
            WriteAttributeValue("", 1524, "/Home/Product/", 1524, 14, true);
#line 39 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
WriteAttributeValue("", 1538, product.Id, 1538, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1550, 30, true);
            WriteLiteral(" class=\"card-title text-muted\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1580, "\"", 1601, 1);
#line 39 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
WriteAttributeValue("", 1588, product.Name, 1588, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1602, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1604, 12, false);
#line 39 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                                                                                                                   Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1616, 61, true);
            WriteLiteral("</a>\r\n                                <div class=\"card-text\">");
            EndContext();
            BeginContext(1678, 28, false);
#line 40 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                                                  Write(product.Price.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 131, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"card-footer\">\r\n                                ");
            EndContext();
            BeginContext(1837, 757, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66eedde7f3853200f921d3a10f96dd96b22583a011648", async() => {
                BeginContext(1908, 58, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1966, "\"", 1985, 1);
#line 44 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
WriteAttributeValue("", 1974, product.Id, 1974, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1986, 141, true);
                WriteLiteral(" name=\"id\" />\r\n                                    <button type=\"submit\" id=\"addToCart\" class=\"btn btn-primary btn-sm\">Add to cart</button>\r\n");
                EndContext();
#line 46 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                                     if (product.Rating > 0)
                                    {

#line default
#line hidden
                BeginContext(2228, 201, true);
                WriteLiteral("                                        <div class=\"float-right\">\r\n                                            <i class=\"fa fa-star star-active\"></i>\r\n                                            <span>");
                EndContext();
                BeginContext(2430, 29, false);
#line 50 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                                             Write(product.Rating.ToString("N2"));

#line default
#line hidden
                EndContext();
                BeginContext(2459, 57, true);
                WriteLiteral("</span>\r\n                                        </div>\r\n");
                EndContext();
#line 52 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                                    }

#line default
#line hidden
                BeginContext(2555, 32, true);
                WriteLiteral("                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2594, 98, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 57 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                }

#line default
#line hidden
#line 57 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                 
            }
            else
            {

#line default
#line hidden
            BeginContext(2759, 113, true);
            WriteLiteral("                <div class=\"col-md-12\">\r\n                    <h5>Product not found</h5>\r\n                </div>\r\n");
            EndContext();
#line 64 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
            }

#line default
#line hidden
            BeginContext(2887, 137, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <table>\r\n                    <tr>\r\n                        <td colspan=\"5\">\r\n                            ");
            EndContext();
            BeginContext(3024, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66eedde7f3853200f921d3a10f96dd96b22583a016693", async() => {
                BeginContext(3092, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3100, 190, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    </table>\r\n</div>\r\n\r\n<script>\r\n    // recheck all selected filters\r\n    $(function () {\r\n        let sortKey = ");
            EndContext();
            BeginContext(3291, 35, false);
#line 79 "F:\ECommercePOC\Web\Views\Home\ProductSearch.cshtml"
                 Write(Json.Serialize(ViewData["SortKey"]));

#line default
#line hidden
            EndContext();
            BeginContext(3326, 522, true);
            WriteLiteral(@";
        $.each(sortKey, function(index, value){
            $(""[id='"" + value + ""']"").prop('checked', true);
        });
    });

    $(function(){
        $('.badge-delete').on('click', function() {
            let idToDelete = $(this).data('value');
            $(this).parent().remove();
            $(""[id='"" + idToDelete + ""']"").prop('checked', false);
            $('#filterForm').submit(); // submit form from file Views/Shared/Components/Filter/Default.cshtml
        });
    });

   
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
