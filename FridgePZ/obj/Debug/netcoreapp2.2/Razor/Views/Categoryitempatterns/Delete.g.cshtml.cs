#pragma checksum "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3720c34d233a0a920ee96101be32eb9f64749425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoryitempatterns_Delete), @"mvc.1.0.view", @"/Views/Categoryitempatterns/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categoryitempatterns/Delete.cshtml", typeof(AspNetCore.Views_Categoryitempatterns_Delete))]
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
#line 1 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\_ViewImports.cshtml"
using FridgePZ.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3720c34d233a0a920ee96101be32eb9f64749425", @"/Views/Categoryitempatterns/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35637e76b85c4316bc78e95a1bdf0b6192c624e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoryitempatterns_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FridgePZ.Models.Categoryitempattern>
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(88, 189, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Categoryitempattern</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(278, 40, false);
#line 15 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(318, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(382, 36, false);
#line 18 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(418, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(481, 40, false);
#line 21 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(521, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(585, 36, false);
#line 24 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(621, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(684, 51, false);
#line 27 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(735, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(799, 47, false);
#line 30 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CurrentQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(846, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(909, 52, false);
#line 33 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ExpectedQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(961, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1025, 48, false);
#line 36 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ExpectedQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1136, 52, false);
#line 39 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ShopingFrequency));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1252, 48, false);
#line 42 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ShopingFrequency));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1363, 48, false);
#line 45 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Notification));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1475, 49, false);
#line 48 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Notification.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1593, 43, false);
#line 51 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Storage));

#line default
#line hidden
            EndContext();
            BeginContext(1636, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1700, 44, false);
#line 54 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Storage.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1788, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3720c34d233a0a920ee96101be32eb9f6474942511622", async() => {
                BeginContext(1814, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1824, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3720c34d233a0a920ee96101be32eb9f6474942512015", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\Lenovo\Documents\FridgeWspolne\fridge-master\Fridge_PZ\FridgePZ\Views\Categoryitempatterns\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryItemPatternId);

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
                BeginContext(1879, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1962, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3720c34d233a0a920ee96101be32eb9f6474942513974", async() => {
                    BeginContext(1984, 12, true);
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
                BeginContext(2000, 6, true);
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
            BeginContext(2013, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FridgePZ.Models.Categoryitempattern> Html { get; private set; }
    }
}
#pragma warning restore 1591
