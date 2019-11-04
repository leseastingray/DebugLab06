#pragma checksum "C:\Users\Student\Documents\RiverRay\CS295N-CourseMaterials\Labs\Lab05\DebuggingPractice-GroupA\DebuggingPractice\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02e487c14798b8c3c3de57e7174e31a753591990"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02e487c14798b8c3c3de57e7174e31a753591990", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Student\Documents\RiverRay\CS295N-CourseMaterials\Labs\Lab05\DebuggingPractice-GroupA\DebuggingPractice\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2702, true);
            WriteLiteral(@"
<h1>HTTP Debugging Practice</h1>

<ol>
    <!--Bug #1-->
    <li>This link should open a <a href=""Demo/Index"">new page</a> named Index in the Views/Demo folder</li>
    <!--Bug #2-->
    <li>This link sends the key-value pair ""mascot, Titans"" to the <a href=""Demo/PageTwo?mascott=Titans"">linked page</a> which will display ""We are the Titans!""</li>
    <!--Bug #3-->
    <li>
        <form action=""Home/NickName"" method=""post"">
            <p> After you submit this form, a page will be shown containing the field names and values you entered.</p>
            <label>Name</label><br />
            <input name=""name"" /><br />
            <label>Nickname</label><br />
            <input name=""nick"" /><br />
            <input type=""submit"" />
        </form>
    </li>
    <!--Bug #4 -->
    <li>
        <form action=""Home/FavFood"" method=""post"">
            <p> Another form like the one above, after submitting, a page will be shown containing the field names and values you entered.</p>
        ");
            WriteLiteral(@"    <h3>Favorite Foods</h3>
            <label>Main Dish</label><br />
            <input id=""main"" /><br />
            <label>Vegetable </label><br />
            <input id=""vegetable"" /><br />
            <label>Desert </label><br />
            <input id=""desert"" /><br />
            <input type=""submit"" />
        </form>
    </li>
    <!-- Bug # 5 -->
    <li>
        <form action=""Home/FavoriteMusic"" method=""post"">
            <p> Another form like the one above, after submitting, a page will be shown containing the field names and values you entered.</p>
            <h3>Favorite Music</h3>
            <label>Genre</label><br />
            <input name=""genre"" /><br />
            <label>Artist</label><br />
            <input name=""song"" /><br />
            <label>Song </label><br />
            <input name=""artist"" /><br />
            <input type=""submit"" />
        </form>
    </li>
    <!-- Bug #6 -->
    <li>This link should open a <a href=""Demo/PageThree"">new page</a> n");
            WriteLiteral(@"amed PageThree in the Views/Demo folder</li>
    <!-- Bug #7 -->
    <li>This link should open a <a href=""Demo/Quiz"">new page</a> named Quiz in the Views/Demo folder containing a form. When you submit the form it should check your answer, and show a new page with ""right"" or ""wrong""</li>
    <!-- Bug #8 -->
    <li>This link should open a <a href=""Demo/Quiz2"">new page</a> named Quiz2 in the Views/Demo folder containing a form. When you submit the form it should check your answer, and show a new page with ""right"" or ""wrong""</li>
    <li>This link should open a <a href=""Demo/PageOne"">new page</a> named Index in the Views/Demo folder</li>
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