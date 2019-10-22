#pragma checksum "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916a12f6e920bcc5594ed0e21cf1a6b84b7f36ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
#line 1 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\_ViewImports.cshtml"
using StudentMVC;

#line default
#line hidden
#line 2 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\_ViewImports.cshtml"
using StudentMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916a12f6e920bcc5594ed0e21cf1a6b84b7f36ba", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ee4b6c45fe245709a8adfb85aeeb8e8e6669789", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentMVC.ViewModel.StudentsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 87, true);
            WriteLiteral("\r\n\r\n<table class=\"form\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(229, 44, false);
#line 13 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(s => Model.Student.Name));

#line default
#line hidden
            EndContext();
            BeginContext(273, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(329, 47, false);
#line 16 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(s => Model.Student.History));

#line default
#line hidden
            EndContext();
            BeginContext(376, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(432, 43, false);
#line 19 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(s => Model.Student.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(475, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(531, 45, false);
#line 22 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(s => Model.Student.Group));

#line default
#line hidden
            EndContext();
            BeginContext(576, 65, true);
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml"
         foreach (var item in Model.Students)
        {

#line default
#line hidden
            BeginContext(699, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(760, 31, false);
#line 32 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(s => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(791, 68, true);
            WriteLiteral(";\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(860, 34, false);
#line 35 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(s => item.History));

#line default
#line hidden
            EndContext();
            BeginContext(894, 68, true);
            WriteLiteral(";\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(963, 30, false);
#line 38 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(s => item.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(993, 68, true);
            WriteLiteral(";\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1062, 42, false);
#line 41 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(s => item.Group.GroupName));

#line default
#line hidden
            EndContext();
            BeginContext(1104, 26, true);
            WriteLiteral(";\r\n                </td>\r\n");
            EndContext();
            BeginContext(1240, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 47 "D:\Module 2\ASP.Net MVC\StudentMVC\StudentMVC\Views\Student\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1270, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentMVC.ViewModel.StudentsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591