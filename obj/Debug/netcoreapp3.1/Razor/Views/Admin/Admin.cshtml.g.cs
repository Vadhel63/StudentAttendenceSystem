#pragma checksum "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e0d74eb912d6b457315f2aa6c06841e765798764c71985decdffd65f2686a5f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Admin), @"mvc.1.0.view", @"/Views/Admin/Admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e0d74eb912d6b457315f2aa6c06841e765798764c71985decdffd65f2686a5f2", @"/Views/Admin/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8eba06800ae5ec35413b60315ac28572dda007bdaabf2c4d06ba2851a0a8ce8d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BranchDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-12 btn btn-secondary py-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
  
    ViewData["Title"] = "AdminPage";
    Layout = "~/Views/Shared/Admin_Layout.cshtml";

    string ErrorMessage = ViewData["ErrorMessage"] as string;
    string SuccessMessage = ViewData["SuccessMessage"] as string;

    List<Branch> branchList = ViewData["branchList"] as List<Branch>;

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<div>\n");
#nullable restore
#line 12 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
     if (null != ErrorMessage)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\n            <strong>\n");
#nullable restore
#line 16 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
                 if (null != ErrorMessage)
                {
                    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 18 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
                     ErrorMessage

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 18 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
                                 
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </strong>\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n                <span aria-hidden=\"true\">&times;</span>\n            </button>\n        </div>\n");
#nullable restore
#line 25 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
    }

#line default
#line hidden
#nullable disable

#nullable restore
#line 26 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
     if (null != SuccessMessage)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\n            <strong>\n");
#nullable restore
#line 30 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
                 if (null != SuccessMessage)
                {
                    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 32 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
                     SuccessMessage

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 32 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
                                   
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </strong>\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n                <span aria-hidden=\"true\">&times;</span>\n            </button>\n        </div>\n");
#nullable restore
#line 39 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</div>\n<br />\n<div class=\"container\">\n    <h1 class=\"text-center mt-4 mb-4\">All Branches</h1>\n    <div class=\"row d-flex justify-content-start mt-4\">\n");
#nullable restore
#line 45 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
         foreach (Branch b in branchList)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <div class=\"col-lg-6 col-md-4 col-sm-12 col-s-12 d-flex justify-content-center py-3\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0d74eb912d6b457315f2aa6c06841e765798764c71985decdffd65f2686a5f29038", async() => {
                WriteLiteral("<h3>");
                Write(
#nullable restore
#line 48 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
                                                                                                                                     b.BranchName

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(" (");
                Write(
#nullable restore
#line 48 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
                                                                                                                                                    b.TotalSemester

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(")&nbsp;</h3>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 48 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
                                                                                    b.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 50 "C:\Users\HP\Downloads\DotNetCoreMVCProject_CE019_CE110-main\DotNetCoreMVCProject_CE019_CE110-main\Views\Admin\Admin.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </div>\n</div>\n");
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
