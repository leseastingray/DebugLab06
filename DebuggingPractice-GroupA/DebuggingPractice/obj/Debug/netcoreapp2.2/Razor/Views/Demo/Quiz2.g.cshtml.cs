#pragma checksum "C:\Users\Student\Documents\RiverRay\Lab05\DebuggingPractice-GroupA\DebuggingPractice\Views\Demo\Quiz2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8135a1e7c7e7ba343b0d291910a90eba7b55b0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Quiz2), @"mvc.1.0.view", @"/Views/Demo/Quiz2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Demo/Quiz2.cshtml", typeof(AspNetCore.Views_Demo_Quiz2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8135a1e7c7e7ba343b0d291910a90eba7b55b0d", @"/Views/Demo/Quiz2.cshtml")]
    public class Views_Demo_Quiz2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Student\Documents\RiverRay\Lab05\DebuggingPractice-GroupA\DebuggingPractice\Views\Demo\Quiz2.cshtml"
  
    ViewBag.Title = "Multiplication";

#line default
#line hidden
            BeginContext(65, 180, true);
            WriteLiteral("\r\n<h2>What is the product of these numbers?</h2>\r\n<form method=\"post\">\r\n    <label for=\"number1\">Number 1</label><br />\r\n    <input type=\"number\" name=\"number1\" readonly=\"readonly\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 245, "\"", 262, 1);
#line 9 "C:\Users\Student\Documents\RiverRay\Lab05\DebuggingPractice-GroupA\DebuggingPractice\Views\Demo\Quiz2.cshtml"
WriteAttributeValue("", 253, Model[0], 253, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(263, 119, true);
            WriteLiteral(" /><br />\r\n    <label for=\"number2\">Number 2</label><br />\r\n    <input type=\"number\" name=\"number2\" readonly=\"readonly\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 382, "\"", 399, 1);
#line 11 "C:\Users\Student\Documents\RiverRay\Lab05\DebuggingPractice-GroupA\DebuggingPractice\Views\Demo\Quiz2.cshtml"
WriteAttributeValue("", 390, Model[1], 390, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(400, 145, true);
            WriteLiteral(" /><br />\r\n    <label for=\"answer\">Product</label><br />\r\n    <input type=\"number\" name=\"answer\" /><br />\r\n    <input type=\"submit\" />\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
