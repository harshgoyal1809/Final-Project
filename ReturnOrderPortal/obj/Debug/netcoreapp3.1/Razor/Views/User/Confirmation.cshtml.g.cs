#pragma checksum "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\User\Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1504eebe7d165f43519bc1deb1c4cd27b668fc24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Confirmation), @"mvc.1.0.view", @"/Views/User/Confirmation.cshtml")]
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
#line 1 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\_ViewImports.cshtml"
using ReturnOrderPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\_ViewImports.cshtml"
using ReturnOrderPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1504eebe7d165f43519bc1deb1c4cd27b668fc24", @"/Views/User/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc37a080bddcf02be731110186ff21c7ffa0e67", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReturnOrderPortal.Models.ProcessResponse>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\User\Confirmation.cshtml"
  
    ViewData["Title"] = "ProcessResponse";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1504eebe7d165f43519bc1deb1c4cd27b668fc243668", async() => {
                WriteLiteral("\n    <link href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css\" rel=\"stylesheet\" />\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1504eebe7d165f43519bc1deb1c4cd27b668fc244742", async() => {
                WriteLiteral("\n    <h1>Processed successfully</h1>\n    <table>\n        <tr>\n            <td>");
#nullable restore
#line 17 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\User\Confirmation.cshtml"
           Write(Html.Label("Request Id"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 19 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\User\Confirmation.cshtml"
           Write(Html.Display("RequestId"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 22 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\User\Confirmation.cshtml"
           Write(Html.Label("Processing Charge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 24 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\User\Confirmation.cshtml"
           Write(Html.Display("ProcessingCharge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 27 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\User\Confirmation.cshtml"
           Write(Html.Label("PackagingAndDeliveryCharge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 29 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\User\Confirmation.cshtml"
           Write(Html.Display("PackagingAndDeliveryCharge"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 32 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\User\Confirmation.cshtml"
           Write(Html.Label("DateOfDelivery"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td></td>\n            <td>");
#nullable restore
#line 34 "C:\Users\HARSH GOYAL\Downloads\ReturnOrderPortal-master\ReturnOrderPortal-master\Views\User\Confirmation.cshtml"
           Write(Html.Display("DateOfDelivery"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>\n\n    </table>\n\n   \n");
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
            WriteLiteral("\n</html>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReturnOrderPortal.Models.ProcessResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
