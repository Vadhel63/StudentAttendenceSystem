#pragma checksum "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "316687457322dd12c9173173aa21deeaffd54fae7e2aee219d7ca3345729f7f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faculty_Faculty), @"mvc.1.0.view", @"/Views/Faculty/Faculty.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\_ViewImports.cshtml"
using StudentAttendanceManagementSystem.Models;

#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\_ViewImports.cshtml"
using StudentAttendanceManagementSystem.Models.DAO;

#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"316687457322dd12c9173173aa21deeaffd54fae7e2aee219d7ca3345729f7f5", @"/Views/Faculty/Faculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8eba06800ae5ec35413b60315ac28572dda007bdaabf2c4d06ba2851a0a8ce8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Faculty_Faculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-item nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Faculty", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Faculty", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary nav-item mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateAttendance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
  
    ViewData["Title"] = "Faculty Page";
    Layout = "~/Views/Shared/_Layout.cshtml";
    string ErrorMessage = ViewData["ErrorMessage"] as string;
    string SuccessMessage = ViewData["SuccessMessage"] as string;
    List<StudentSubject> studentlist = ViewData["StudentSubjectList"] as List<StudentSubject>;
    Subject CurrentSubject = ViewData["Subject"] as Subject;
    Faculty CurrentFaculty = ViewData["Faculty"] as Faculty;

#line default
#line hidden
#nullable disable

            WriteLiteral("<div>\n    <nav class=\"navbar navbar-expand-lg navbar-light bg-light\" style=\"background-color: #e3f2fd;\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "316687457322dd12c9173173aa21deeaffd54fae7e2aee219d7ca3345729f7f57653", async() => {
                WriteLiteral("DRU");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavAltMarkup"" aria-controls=""navbarNavAltMarkup"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarNavAltMarkup"">
            <div class=""navbar-nav"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "316687457322dd12c9173173aa21deeaffd54fae7e2aee219d7ca3345729f7f59533", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <a class=\"nav-item nav-link\" href=\"#\">Subjects</a>\n                <a class=\"nav-item nav-link\" href=\"#\">Profile</a>\n            </div>\n        </div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "316687457322dd12c9173173aa21deeaffd54fae7e2aee219d7ca3345729f7f511184", async() => {
                WriteLiteral("Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </nav>\n</div>\n");
            WriteLiteral("<div>\n");
#nullable restore
#line 28 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
     if (null != ErrorMessage)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\n            <strong>\n");
#nullable restore
#line 32 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                 if (null != ErrorMessage)
                {
                    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 34 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                     ErrorMessage

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 34 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                                 
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </strong>\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n                <span aria-hidden=\"true\">&times;</span>\n            </button>\n        </div>\n");
#nullable restore
#line 41 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 42 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
     if (null != SuccessMessage)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\n            <strong>\n");
#nullable restore
#line 46 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                 if (null != SuccessMessage)
                {
                    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 48 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                     SuccessMessage

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 48 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                                   
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </strong>\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n                <span aria-hidden=\"true\">&times;</span>\n            </button>\n        </div>\n");
#nullable restore
#line 55 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</div>\n<div class=\"container\">\n    <h1 class=\"text-center my-4\">");
            Write(
#nullable restore
#line 58 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                                  CurrentSubject.SubjectName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" (");
            Write(
#nullable restore
#line 58 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                                                               CurrentSubject.SubjectCode

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@")</h1>
    <table class=""table table-hover mt-3"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">StudentId</th>
                <th scope=""col"">Attendance</th>
                <th scope=""col""><span class=""glyphicon"">&#x270f;</span>Edit</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 69 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
             for(int i=0;i<studentlist.Count;i++){

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\n                    <th scope=\"row\">");
            Write(
#nullable restore
#line 71 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                                      i+1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\n                    <td>");
            Write(
#nullable restore
#line 72 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                         studentlist[i].Student.UniversityId

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n                    <td>");
            Write(
#nullable restore
#line 73 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                         studentlist[i].Attendance

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "316687457322dd12c9173173aa21deeaffd54fae7e2aee219d7ca3345729f7f518688", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-objId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 74 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
                                                                                                    studentlist[i].Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["objId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-objId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["objId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 76 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Faculty\Faculty.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </tbody>\n    </table>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
