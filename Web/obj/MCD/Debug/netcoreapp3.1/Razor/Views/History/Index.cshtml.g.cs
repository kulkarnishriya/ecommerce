#pragma checksum "F:\ECommercePOC\Web\Views\History\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "232e517c389314ce1c919905cb7c264710929f3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_History_Index), @"mvc.1.0.view", @"/Views/History/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/History/Index.cshtml", typeof(AspNetCore.Views_History_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"232e517c389314ce1c919905cb7c264710929f3f", @"/Views/History/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_History_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HistoryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/system/no-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-item-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "History", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232e517c389314ce1c919905cb7c264710929f3f5780", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
  
    Layout = "_CommonLayout";

#line default
#line hidden
#line 6 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
  
    ViewData["Title"] = "History";

#line default
#line hidden
            BeginContext(172, 35, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>");
            EndContext();
            BeginContext(208, 17, false);
#line 11 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(225, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 12 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
     if (Model != null && Model.Count() > 0)
    {
        

#line default
#line hidden
            BeginContext(295, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(303, 2128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232e517c389314ce1c919905cb7c264710929f3f7910", async() => {
                BeginContext(334, 403, true);
                WriteLiteral(@"
            <table class=""table"">
                <thead>
                    <tr>
                        <td></td>
                        <td>Name</td>
                        <td>Quantity</td>
                        <td>Price</td>
                        <td>Date</td>
                        <td>Action</td>
                    </tr>
                </thead>
                <tbody>
");
                EndContext();
#line 28 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
                     foreach (var cartItem in Model)
                    {

#line default
#line hidden
                BeginContext(814, 145, true);
                WriteLiteral("                        <tr>\r\n                            <td style=\"width: 15%\">\r\n                                <div class=\"text-sm-center\">\r\n");
                EndContext();
#line 33 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
                                     if (cartItem.ProductImage != null)
                                    {

#line default
#line hidden
                BeginContext(1071, 44, true);
                WriteLiteral("                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1115, "\"", 1143, 1);
#line 35 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
WriteAttributeValue("", 1121, cartItem.ProductImage, 1121, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1144, 24, true);
                WriteLiteral(" class=\"cart-item-image\"");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 1168, "\"", 1188, 1);
#line 35 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
WriteAttributeValue("", 1174, cartItem.Name, 1174, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1189, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 36 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                BeginContext(1314, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(1354, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "232e517c389314ce1c919905cb7c264710929f3f10657", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
AddHtmlAttributeValue("", 1423, cartItem.Name, 1423, 14, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1441, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
                                    }

#line default
#line hidden
                BeginContext(1482, 160, true);
                WriteLiteral("                                </div>\r\n                            </td>\r\n                            <td style=\"width: 40%\">\r\n                                ");
                EndContext();
                BeginContext(1643, 13, false);
#line 44 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
                           Write(cartItem.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1656, 121, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"width: 17%\">\r\n                               ");
                EndContext();
                BeginContext(1778, 17, false);
#line 47 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
                          Write(cartItem.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(1795, 140, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"width: 18%;\">\r\n                                <div class=\"\">Rs.");
                EndContext();
                BeginContext(1936, 29, false);
#line 50 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
                                            Write(cartItem.Price.ToString("C2"));

#line default
#line hidden
                EndContext();
                BeginContext(1965, 128, true);
                WriteLiteral("</div>\r\n                            </td>\r\n                            <td style=\"width: 10%\">\r\n                                ");
                EndContext();
                BeginContext(2094, 23, false);
#line 53 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
                           Write(cartItem.DateofPurchase);

#line default
#line hidden
                EndContext();
                BeginContext(2117, 122, true);
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"width: 10%\">\r\n                                ");
                EndContext();
                BeginContext(2240, 15, false);
#line 56 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
                           Write(cartItem.Action);

#line default
#line hidden
                EndContext();
                BeginContext(2255, 68, true);
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 59 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(2346, 78, true);
                WriteLiteral("                    \r\n                </tbody>\r\n            </table>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2431, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 64 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2457, 36, true);
            WriteLiteral("        <h5>No History found.</h5>\r\n");
            EndContext();
#line 68 "F:\ECommercePOC\Web\Views\History\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2500, 117, true);
            WriteLiteral("            <table>\r\n                    <tr>\r\n                        <td colspan=\"5\">\r\n                            ");
            EndContext();
            BeginContext(2617, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232e517c389314ce1c919905cb7c264710929f3f17283", async() => {
                BeginContext(2685, 4, true);
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
            BeginContext(2693, 98, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HistoryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
