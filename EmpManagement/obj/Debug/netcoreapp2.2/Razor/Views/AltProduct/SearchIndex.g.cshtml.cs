#pragma checksum "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f79d3aa421d43bfc12fd6f3da2a90270c23c7009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AltProduct_SearchIndex), @"mvc.1.0.view", @"/Views/AltProduct/SearchIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AltProduct/SearchIndex.cshtml", typeof(AspNetCore.Views_AltProduct_SearchIndex))]
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
#line 1 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using EmpManagement.Models;

#line default
#line hidden
#line 2 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using EmpManagement.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79d3aa421d43bfc12fd6f3da2a90270c23c7009", @"/Views/AltProduct/SearchIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d6ec5c308294d61a3bbb40d8c9044fb01a3987", @"/Views/_ViewImports.cshtml")]
    public class Views_AltProduct_SearchIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<EmpManagement.Models.AltProduct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AltProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure ?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "altproduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(89, 366, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f79d3aa421d43bfc12fd6f3da2a90270c23c70097355", async() => {
                BeginContext(95, 98, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Product List</title>\r\n    ");
                EndContext();
                BeginContext(193, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f79d3aa421d43bfc12fd6f3da2a90270c23c70097840", async() => {
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
                EndContext();
                BeginContext(253, 36, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 289, "\"", 339, 1);
#line 9 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
WriteAttributeValue("", 295, Url.Action("~/scripts/jquery-3.3.1.min.js"), 295, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(340, 46, true);
                WriteLiteral("></script>\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 386, "\"", 433, 1);
#line 10 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
WriteAttributeValue("", 392, Url.Action("~/scripts/bootstrap.min.js"), 392, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(434, 14, true);
                WriteLiteral("></script>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(455, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(457, 2254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f79d3aa421d43bfc12fd6f3da2a90270c23c700911084", async() => {
                BeginContext(463, 69, true);
                WriteLiteral("\r\n    <div class=\"container\" style=\"margin-top: 20px;\">\r\n\r\n\r\n        ");
                EndContext();
                BeginContext(532, 2158, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f79d3aa421d43bfc12fd6f3da2a90270c23c700911546", async() => {
                    BeginContext(599, 47, true);
                    WriteLiteral("\r\n            <input type=\"text\" name=\"keyword\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 646, "\"", 670, 1);
#line 18 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
WriteAttributeValue("", 654, ViewBag.keyword, 654, 16, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(671, 57, true);
                    WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Search\" />\r\n");
                    EndContext();
#line 20 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
             if (Model != null)
            {

#line default
#line hidden
                    BeginContext(776, 726, true);
                    WriteLiteral(@"                <h4 class=""text-center text-uppercase"">Product List</h4>
                <table class=""table table-striped table-bordered"">
                    <thead class=""bg-dark text-white"">
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Status</th>
                            <th>Price</th>
                            <th>Quantity</th>
                            <th>Project</th>
                            <th>RentedFrom</th>
                            <th>RentedTo</th>
                            <th>Options</th>
                        </tr>
                    </thead>
                    <tbody>
");
                    EndContext();
#line 38 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
                         foreach (var AltProduct in Model)
                        {

#line default
#line hidden
                    BeginContext(1589, 70, true);
                    WriteLiteral("                            <tr>\r\n                                <td>");
                    EndContext();
                    BeginContext(1660, 13, false);
#line 41 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
                               Write(AltProduct.Id);

#line default
#line hidden
                    EndContext();
                    BeginContext(1673, 43, true);
                    WriteLiteral("</td>\r\n                                <td>");
                    EndContext();
                    BeginContext(1717, 15, false);
#line 42 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
                               Write(AltProduct.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(1732, 43, true);
                    WriteLiteral("</td>\r\n                                <td>");
                    EndContext();
                    BeginContext(1776, 17, false);
#line 43 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
                               Write(AltProduct.Status);

#line default
#line hidden
                    EndContext();
                    BeginContext(1793, 43, true);
                    WriteLiteral("</td>\r\n                                <td>");
                    EndContext();
                    BeginContext(1837, 16, false);
#line 44 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
                               Write(AltProduct.Price);

#line default
#line hidden
                    EndContext();
                    BeginContext(1853, 45, true);
                    WriteLiteral("</td>\r\n\r\n                                <td>");
                    EndContext();
                    BeginContext(1899, 19, false);
#line 46 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
                               Write(AltProduct.Quantity);

#line default
#line hidden
                    EndContext();
                    BeginContext(1918, 45, true);
                    WriteLiteral("</td>\r\n\r\n                                <td>");
                    EndContext();
                    BeginContext(1964, 18, false);
#line 48 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
                               Write(AltProduct.Project);

#line default
#line hidden
                    EndContext();
                    BeginContext(1982, 45, true);
                    WriteLiteral("</td>\r\n\r\n                                <td>");
                    EndContext();
                    BeginContext(2028, 21, false);
#line 50 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
                               Write(AltProduct.RentedFrom);

#line default
#line hidden
                    EndContext();
                    BeginContext(2049, 45, true);
                    WriteLiteral("</td>\r\n\r\n                                <td>");
                    EndContext();
                    BeginContext(2095, 19, false);
#line 52 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
                               Write(AltProduct.RentedTo);

#line default
#line hidden
                    EndContext();
                    BeginContext(2114, 83, true);
                    WriteLiteral("</td>\r\n\r\n                                <td>\r\n                                    ");
                    EndContext();
                    BeginContext(2197, 87, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f79d3aa421d43bfc12fd6f3da2a90270c23c700918239", async() => {
                        BeginContext(2276, 4, true);
                        WriteLiteral("Edit");
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
#line 55 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
                                                                                       WriteLiteral(AltProduct.Id);

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
                    BeginContext(2284, 77, true);
                    WriteLiteral("\r\n                                    |\r\n                                    ");
                    EndContext();
                    BeginContext(2361, 134, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f79d3aa421d43bfc12fd6f3da2a90270c23c700921228", async() => {
                        BeginContext(2485, 6, true);
                        WriteLiteral("Delete");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#line 57 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
                                                                                         WriteLiteral(AltProduct.Id);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2495, 80, true);
                    WriteLiteral("\r\n                                </td>\r\n\r\n\r\n                            </tr>\r\n");
                    EndContext();
#line 62 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"

                        }

#line default
#line hidden
                    BeginContext(2604, 56, true);
                    WriteLiteral("                    </tbody>\r\n                </table>\r\n");
                    EndContext();
#line 66 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AltProduct\SearchIndex.cshtml"
            }

#line default
#line hidden
                    BeginContext(2675, 8, true);
                    WriteLiteral("        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2690, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2711, 278, true);
            WriteLiteral(@"
</html>
<style>
    body {
        background: url('https://images.pexels.com/photos/1323712/pexels-photo-1323712.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500') no-repeat fixed center center;
        background-size: cover;
        font-family: Montserrat;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<EmpManagement.Models.AltProduct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
