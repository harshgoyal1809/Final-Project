#pragma checksum "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal (1)\ReturnOrderPortal\Views\User\ErrorHandle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ee3bead998d57500cc60717c25545cb1d3a460c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ErrorHandle), @"mvc.1.0.view", @"/Views/User/ErrorHandle.cshtml")]
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
#nullable restore
#line 1 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal (1)\ReturnOrderPortal\Views\_ViewImports.cshtml"
using Return_Order_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal (1)\ReturnOrderPortal\Views\_ViewImports.cshtml"
using Return_Order_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee3bead998d57500cc60717c25545cb1d3a460c", @"/Views/User/ErrorHandle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28219d04afb92109702e05c54c5a31345b8d3058", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ErrorHandle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>An Error Occured while Processing your Request</h3>\n\n\n<hr />\n<h3>Details:</h3>\n<div class=\"alert alert-danger\">\n    <h5>Some Error occurred</h5>\n    <hr/>\n    <p>");
#nullable restore
#line 9 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal (1)\ReturnOrderPortal\Views\User\ErrorHandle.cshtml"
  Write(ViewBag.ExceptionPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n\n<div class=\"alert alert-danger\">\n    <h5>Exception Message</h5>\n    <hr />\n    <p>");
#nullable restore
#line 15 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal (1)\ReturnOrderPortal\Views\User\ErrorHandle.cshtml"
  Write(ViewBag.ExceptionMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n\n<div class=\"alert alert-danger\">\n    <h5>Exception Stack Trace</h5>\n    <hr />\n    <p>");
#nullable restore
#line 21 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal (1)\ReturnOrderPortal\Views\User\ErrorHandle.cshtml"
  Write(ViewBag.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
