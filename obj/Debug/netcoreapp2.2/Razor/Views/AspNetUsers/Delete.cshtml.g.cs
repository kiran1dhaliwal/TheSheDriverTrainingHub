#pragma checksum "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7764b61adb737217c4ce3401d72935eb371513b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AspNetUsers_Delete), @"mvc.1.0.view", @"/Views/AspNetUsers/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AspNetUsers/Delete.cshtml", typeof(AspNetCore.Views_AspNetUsers_Delete))]
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
#line 1 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\_ViewImports.cshtml"
using TheFinalSheDriverTrainingHub;

#line default
#line hidden
#line 2 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\_ViewImports.cshtml"
using TheFinalSheDriverTrainingHub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7764b61adb737217c4ce3401d72935eb371513b", @"/Views/AspNetUsers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35a6d8d8ddaaf73a7141ed65067cfe10acb334c9", @"/Views/_ViewImports.cshtml")]
    public class Views_AspNetUsers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheFinalSheDriverTrainingHub.Models.DB.AspNetUsers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AspNetUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(103, 200, true);
            WriteLiteral("\r\n<h3 style=\"font-family:\'Footlight MT\'\">Are you sure you want to delete this instructor?</h3>\r\n<div id=\"title\" style=\"padding:20px\">\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(304, 45, false);
#line 11 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(349, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(411, 41, false);
#line 14 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(452, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(513, 44, false);
#line 17 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(557, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(619, 40, false);
#line 20 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(659, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(720, 41, false);
#line 23 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(761, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(823, 37, false);
#line 26 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(860, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(921, 47, false);
#line 29 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(968, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1030, 43, false);
#line 32 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1134, 42, false);
#line 35 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Suburb));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1238, 38, false);
#line 38 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Suburb));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1337, 40, false);
#line 41 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1439, 36, false);
#line 44 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1536, 49, false);
#line 47 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LicenseNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1585, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1647, 45, false);
#line 50 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LicenseNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1692, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1753, 50, false);
#line 53 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LicenseVersion));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1865, 46, false);
#line 56 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LicenseVersion));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1972, 46, false);
#line 59 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsEndorsed));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2080, 42, false);
#line 62 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsEndorsed));

#line default
#line hidden
            EndContext();
            BeginContext(2122, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2183, 42, false);
#line 65 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Monday));

#line default
#line hidden
            EndContext();
            BeginContext(2225, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2287, 38, false);
#line 68 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Monday));

#line default
#line hidden
            EndContext();
            BeginContext(2325, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2386, 43, false);
#line 71 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tuesday));

#line default
#line hidden
            EndContext();
            BeginContext(2429, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2491, 39, false);
#line 74 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tuesday));

#line default
#line hidden
            EndContext();
            BeginContext(2530, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2591, 45, false);
#line 77 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Wednesday));

#line default
#line hidden
            EndContext();
            BeginContext(2636, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2698, 41, false);
#line 80 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Wednesday));

#line default
#line hidden
            EndContext();
            BeginContext(2739, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2800, 44, false);
#line 83 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Thursday));

#line default
#line hidden
            EndContext();
            BeginContext(2844, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2906, 40, false);
#line 86 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Thursday));

#line default
#line hidden
            EndContext();
            BeginContext(2946, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3007, 42, false);
#line 89 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Friday));

#line default
#line hidden
            EndContext();
            BeginContext(3049, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3111, 38, false);
#line 92 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Friday));

#line default
#line hidden
            EndContext();
            BeginContext(3149, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3210, 44, false);
#line 95 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Saturday));

#line default
#line hidden
            EndContext();
            BeginContext(3254, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3316, 40, false);
#line 98 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Saturday));

#line default
#line hidden
            EndContext();
            BeginContext(3356, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3417, 42, false);
#line 101 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sunday));

#line default
#line hidden
            EndContext();
            BeginContext(3459, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3521, 38, false);
#line 104 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sunday));

#line default
#line hidden
            EndContext();
            BeginContext(3559, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3620, 50, false);
#line 107 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AvailableTimes));

#line default
#line hidden
            EndContext();
            BeginContext(3670, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3732, 46, false);
#line 110 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AvailableTimes));

#line default
#line hidden
            EndContext();
            BeginContext(3778, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3839, 48, false);
#line 113 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePerHour));

#line default
#line hidden
            EndContext();
            BeginContext(3887, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3949, 44, false);
#line 116 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PricePerHour));

#line default
#line hidden
            EndContext();
            BeginContext(3993, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(4027, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7764b61adb737217c4ce3401d72935eb371513b21188", async() => {
                BeginContext(4053, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4063, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7764b61adb737217c4ce3401d72935eb371513b21581", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 121 "C:\Users\kiran\OneDrive\Documents\TheFinalSheDriverTrainingHub\Views\AspNetUsers\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                BeginContext(4099, 79, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4185, 47, true);
            WriteLiteral("\r\n\r\n    <div style=\"margin-top:20px\">\r\n        ");
            EndContext();
            BeginContext(4232, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7764b61adb737217c4ce3401d72935eb371513b24816", async() => {
                BeginContext(4283, 31, true);
                WriteLiteral(" <button>Back to List</button> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4318, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheFinalSheDriverTrainingHub.Models.DB.AspNetUsers> Html { get; private set; }
    }
}
#pragma warning restore 1591