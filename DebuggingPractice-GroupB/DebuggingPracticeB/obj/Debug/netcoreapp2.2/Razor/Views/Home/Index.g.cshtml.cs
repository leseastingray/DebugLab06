#pragma checksum "C:\Users\Student\Documents\RiverRay\Lab05\DebuggingPractice-GroupB\DebuggingPracticeB\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b752a433a625ae6b4e2422ceaffda67d85ae3d53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b752a433a625ae6b4e2422ceaffda67d85ae3d53", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Student\Documents\RiverRay\Lab05\DebuggingPractice-GroupB\DebuggingPracticeB\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2656, true);
            WriteLiteral(@"
<h1>Debugging Practice for Group B</h1>

<ol>
    <!--Bug #1-->
    <li>This link should open a <a href=""Demo/Index"">new page</a> named Index in the Views/Demo folder</li>

    <!--Bug #2-->
    <li>This link sends the key-value pair ""mascot, Ducks"" to the <a href=""Demo/PageTwo?mascot=Ducks"">linked page</a> which will display ""We are the Ducks!""</li>

    <!--Bug #3-->
    <li>
        <p> After you submit this form, a page will be shown containing the field names and values you entered.</p>
           <form action=""Home/HomeTown"" method=""post"">
            <h3>Your Hometown</h3>
            <label>State</label><br />
            <input name=""state"" /><br />
            <label>City</label><br />
            <input name=""city"" /><br />
            <input type=""submit"" />
        </form>
    </li>

    <!--Bug #4 -->
    <li>
        <p> Another form like the one above, after submitting, a page will be shown containing the field names and values you entered.</p>
        <form action=""");
            WriteLiteral(@"Home/Vacation"" method=""post"">
            <h3>Favorite Vacation</h3>
            <label>Location</label><br />
            <input name=""location"" /><br />
            <label>Activity</label><br />
            <input name=""activity"" /><br />
            <label>What to wear</label><br />
            <input name=""clothing"" /><br />
            <input type=""submit"" />
        </form>
    </li>

    <!-- Bug # 5 -->
    <li>
        <form action=""Home/Reading"" method=""post"">
            <p> Another form like the one above, after submitting, a page will be shown containing the field names and values you entered.</p>
            <h3>Favorite Reading</h3>
            <label>Genre</label><br />
            <input name=""genre"" /><br />
            <label>Author</label><br />
            <input name=""author"" /><br />
            <label>Book </label><br />
            <input name=""book"" /><br />
            <input type=""submit"" />
        </form>
    </li>

    <!-- Bug #6 -->
    <li>This lin");
            WriteLiteral(@"k should open a <a href=""Demo/PageThree"">new page</a> named PageThree in the Views/Demo folder</li>

    <!-- Bug #7:  -->
    <li>This link should open a <a href=""Demo/Quiz1"">new page</a> named Quiz1 in the Views/Demo folder containing a form. When you submit the form it should check your answer, and show a new page with ""right"" or ""wrong""</li>

    <!-- Bug #8 -->
    <li>This link should open a <a href=""Demo/Quiz2"">new page</a> named Quiz2 in the Views/Demo folder containing a form. When you submit the form it should check your answer, and show a new page with ""right"" or ""wrong""</li>
  </ol>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
