#pragma checksum "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64d2548aef1a4cf290da0c737a8ce3f72b855193"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jacket_SearchSalesIndex), @"mvc.1.0.view", @"/Views/Jacket/SearchSalesIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jacket/SearchSalesIndex.cshtml", typeof(AspNetCore.Views_Jacket_SearchSalesIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64d2548aef1a4cf290da0c737a8ce3f72b855193", @"/Views/Jacket/SearchSalesIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d6ec5c308294d61a3bbb40d8c9044fb01a3987", @"/Views/_ViewImports.cshtml")]
    public class Views_Jacket_SearchSalesIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<EmpManagement.Models.Jacket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Jacket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure ?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "jacket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "searchsales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(58, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(85, 373, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64d2548aef1a4cf290da0c737a8ce3f72b8551937355", async() => {
                BeginContext(91, 105, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Jacket Project List</title>\r\n    ");
                EndContext();
                BeginContext(196, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64d2548aef1a4cf290da0c737a8ce3f72b8551937848", async() => {
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
                BeginContext(256, 36, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 292, "\"", 342, 1);
#line 9 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
WriteAttributeValue("", 298, Url.Action("~/scripts/jquery-3.3.1.min.js"), 298, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(343, 46, true);
                WriteLiteral("></script>\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 389, "\"", 436, 1);
#line 10 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
WriteAttributeValue("", 395, Url.Action("~/scripts/bootstrap.min.js"), 395, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(437, 14, true);
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
            BeginContext(458, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(460, 1983, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64d2548aef1a4cf290da0c737a8ce3f72b85519311094", async() => {
                BeginContext(466, 69, true);
                WriteLiteral("\r\n    <div class=\"container\" style=\"margin-top: 20px;\">\r\n\r\n\r\n        ");
                EndContext();
                BeginContext(535, 1887, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64d2548aef1a4cf290da0c737a8ce3f72b85519311556", async() => {
                    BeginContext(603, 47, true);
                    WriteLiteral("\r\n            <input type=\"text\" name=\"keyword\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 650, "\"", 674, 1);
#line 18 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
WriteAttributeValue("", 658, ViewBag.keyword, 658, 16, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(675, 57, true);
                    WriteLiteral(" />\r\n            <input type=\"submit\" value=\"Search\" />\r\n");
                    EndContext();
#line 20 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
             if (Model != null)
            {

#line default
#line hidden
                    BeginContext(780, 637, true);
                    WriteLiteral(@"                <h4 class=""text-center text-uppercase"">Sales To Do List</h4>
                <table class=""table table-striped table-bordered"">
                    <thead class=""bg-dark text-white"">
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Description</th>
                            <th>Priority</th>
                            <th>Status</th>
                            <th>Role</th>
                            <th>Options</th>
                        </tr>
                    </thead>
                    <tbody>
");
                    EndContext();
#line 36 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
                         foreach (var Jacket in Model)
                        {

#line default
#line hidden
                    BeginContext(1500, 70, true);
                    WriteLiteral("                            <tr>\r\n                                <td>");
                    EndContext();
                    BeginContext(1571, 9, false);
#line 39 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
                               Write(Jacket.Id);

#line default
#line hidden
                    EndContext();
                    BeginContext(1580, 43, true);
                    WriteLiteral("</td>\r\n                                <td>");
                    EndContext();
                    BeginContext(1624, 11, false);
#line 40 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
                               Write(Jacket.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(1635, 43, true);
                    WriteLiteral("</td>\r\n                                <td>");
                    EndContext();
                    BeginContext(1679, 18, false);
#line 41 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
                               Write(Jacket.Description);

#line default
#line hidden
                    EndContext();
                    BeginContext(1697, 45, true);
                    WriteLiteral("</td>\r\n\r\n                                <td>");
                    EndContext();
                    BeginContext(1743, 15, false);
#line 43 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
                               Write(Jacket.Priority);

#line default
#line hidden
                    EndContext();
                    BeginContext(1758, 45, true);
                    WriteLiteral("</td>\r\n\r\n                                <td>");
                    EndContext();
                    BeginContext(1804, 13, false);
#line 45 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
                               Write(Jacket.Status);

#line default
#line hidden
                    EndContext();
                    BeginContext(1817, 45, true);
                    WriteLiteral("</td>\r\n\r\n                                <td>");
                    EndContext();
                    BeginContext(1863, 11, false);
#line 47 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
                               Write(Jacket.Role);

#line default
#line hidden
                    EndContext();
                    BeginContext(1874, 85, true);
                    WriteLiteral("</td>\r\n\r\n\r\n                                <td>\r\n                                    ");
                    EndContext();
                    BeginContext(1959, 79, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64d2548aef1a4cf290da0c737a8ce3f72b85519317127", async() => {
                        BeginContext(2030, 4, true);
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
#line 51 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
                                                                                   WriteLiteral(Jacket.Id);

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
                    BeginContext(2038, 77, true);
                    WriteLiteral("\r\n                                    |\r\n                                    ");
                    EndContext();
                    BeginContext(2115, 126, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64d2548aef1a4cf290da0c737a8ce3f72b85519320109", async() => {
                        BeginContext(2231, 6, true);
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
#line 53 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
                                                                                     WriteLiteral(Jacket.Id);

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
                    BeginContext(2241, 80, true);
                    WriteLiteral("\r\n                                </td>\r\n\r\n\r\n                            </tr>\r\n");
                    EndContext();
#line 58 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"

                        }

#line default
#line hidden
                    BeginContext(2350, 54, true);
                    WriteLiteral("                    </tbody>\r\n                </table>");
                    EndContext();
#line 61 "C:\Users\Nirbhay Malhotra\Downloads\Security (7)\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Jacket\SearchSalesIndex.cshtml"
                        }

#line default
#line hidden
                    BeginContext(2407, 8, true);
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
                BeginContext(2422, 14, true);
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
            BeginContext(2443, 278, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<EmpManagement.Models.Jacket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
