#pragma checksum "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "715735331554d4513a7231f842c3028d86472b5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Itempatterns_Delete), @"mvc.1.0.view", @"/Views/Itempatterns/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Itempatterns/Delete.cshtml", typeof(AspNetCore.Views_Itempatterns_Delete))]
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
#line 1 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"715735331554d4513a7231f842c3028d86472b5f", @"/Views/Itempatterns/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35637e76b85c4316bc78e95a1bdf0b6192c624e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Itempatterns_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FridgePZ.Models.Itempattern>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(80, 179, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Itempattern</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(260, 43, false);
#line 15 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BarCode));

#line default
#line hidden
            EndContext();
            BeginContext(303, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(365, 39, false);
#line 18 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BarCode));

#line default
#line hidden
            EndContext();
            BeginContext(404, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(465, 40, false);
#line 21 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(505, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(567, 36, false);
#line 24 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Unit));

#line default
#line hidden
            EndContext();
            BeginContext(603, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(664, 40, false);
#line 27 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(704, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(766, 36, false);
#line 30 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(802, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(863, 40, false);
#line 33 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(903, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(965, 36, false);
#line 36 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1062, 44, false);
#line 39 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1168, 40, false);
#line 42 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1269, 49, false);
#line 45 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SeverityLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1380, 45, false);
#line 48 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SeverityLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1486, 44, false);
#line 51 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LongLife));

#line default
#line hidden
            EndContext();
            BeginContext(1530, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1592, 40, false);
#line 54 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LongLife));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1693, 44, false);
#line 57 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LongLife));

#line default
#line hidden
            EndContext();
            BeginContext(1737, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1799, 40, false);
#line 60 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LongLife));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1900, 55, false);
#line 63 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryItemPattern));

#line default
#line hidden
            EndContext();
            BeginContext(1955, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2017, 56, false);
#line 66 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CategoryItemPattern.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2073, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2111, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "715735331554d4513a7231f842c3028d86472b5f13610", async() => {
                BeginContext(2137, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2147, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "715735331554d4513a7231f842c3028d86472b5f14003", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ(najnowsza)\Fridge_PZ\FridgePZ\Views\Itempatterns\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ItemPatternId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2194, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2277, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "715735331554d4513a7231f842c3028d86472b5f15967", async() => {
                    BeginContext(2299, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2315, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2328, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FridgePZ.Models.Itempattern> Html { get; private set; }
    }
}
#pragma warning restore 1591
