#pragma checksum "C:\WOTProject\WoTWithBs4\Pages\Wot\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6026f288f8001f2e073665102f9bbeb99deef6e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WoTWithBs4.Pages.Wot.Pages_Wot_Detail), @"mvc.1.0.razor-page", @"/Pages/Wot/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Wot/Detail.cshtml", typeof(WoTWithBs4.Pages.Wot.Pages_Wot_Detail), null)]
namespace WoTWithBs4.Pages.Wot
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\WOTProject\WoTWithBs4\Pages\_ViewImports.cshtml"
using WoTWithBs4;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6026f288f8001f2e073665102f9bbeb99deef6e7", @"/Pages/Wot/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c42acb61faa628b0693048e42505b108a275ee8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Wot_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Tank", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\WOTProject\WoTWithBs4\Pages\Wot\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(90, 42, true);
            WriteLiteral("\r\n<h1>Detail</h1>\r\n\r\n<p class=\"display-4\">");
            EndContext();
            BeginContext(133, 19, false);
#line 9 "C:\WOTProject\WoTWithBs4\Pages\Wot\Detail.cshtml"
                Write(Model.tank.TankName);

#line default
#line hidden
            EndContext();
            BeginContext(152, 93, true);
            WriteLiteral("</p>\r\n<table class=\"table table-dark w-50\">\r\n    <tr>\r\n        <th>TankId </th>\r\n        <td>");
            EndContext();
            BeginContext(246, 17, false);
#line 13 "C:\WOTProject\WoTWithBs4\Pages\Wot\Detail.cshtml"
       Write(Model.tank.TankId);

#line default
#line hidden
            EndContext();
            BeginContext(263, 68, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>TankTier </th>\r\n        <td>");
            EndContext();
            BeginContext(332, 19, false);
#line 17 "C:\WOTProject\WoTWithBs4\Pages\Wot\Detail.cshtml"
       Write(Model.tank.TankTier);

#line default
#line hidden
            EndContext();
            BeginContext(351, 69, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>FirePower </th>\r\n        <td>");
            EndContext();
            BeginContext(421, 20, false);
#line 21 "C:\WOTProject\WoTWithBs4\Pages\Wot\Detail.cshtml"
       Write(Model.tank.FirePower);

#line default
#line hidden
            EndContext();
            BeginContext(441, 73, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Survivability </th>\r\n        <td>");
            EndContext();
            BeginContext(515, 24, false);
#line 25 "C:\WOTProject\WoTWithBs4\Pages\Wot\Detail.cshtml"
       Write(Model.tank.Survivability);

#line default
#line hidden
            EndContext();
            BeginContext(539, 71, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Concealment </th>\r\n        <td>");
            EndContext();
            BeginContext(611, 22, false);
#line 29 "C:\WOTProject\WoTWithBs4\Pages\Wot\Detail.cshtml"
       Write(Model.tank.Concealment);

#line default
#line hidden
            EndContext();
            BeginContext(633, 68, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Spotting </th>\r\n        <td>");
            EndContext();
            BeginContext(702, 19, false);
#line 33 "C:\WOTProject\WoTWithBs4\Pages\Wot\Detail.cshtml"
       Write(Model.tank.Spotting);

#line default
#line hidden
            EndContext();
            BeginContext(721, 30, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(751, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6026f288f8001f2e073665102f9bbeb99deef6e76109", async() => {
                BeginContext(772, 12, true);
                WriteLiteral("Back to tank");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WoTWithBs4.Pages.Wot.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WoTWithBs4.Pages.Wot.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WoTWithBs4.Pages.Wot.DetailModel>)PageContext?.ViewData;
        public WoTWithBs4.Pages.Wot.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591