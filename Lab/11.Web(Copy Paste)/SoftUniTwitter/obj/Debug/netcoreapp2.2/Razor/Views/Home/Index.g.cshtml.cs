#pragma checksum "D:\SoftUni\TechModule\Lab\Web\SoftUniTwitter\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b2e6a756ee2a266afea87df6ade55399d7faf3a"
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
#line 1 "D:\SoftUni\TechModule\Lab\Web\SoftUniTwitter\Views\_ViewImports.cshtml"
using SoftUniTwitter;

#line default
#line hidden
#line 2 "D:\SoftUni\TechModule\Lab\Web\SoftUniTwitter\Views\_ViewImports.cshtml"
using SoftUniTwitter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b2e6a756ee2a266afea87df6ade55399d7faf3a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7984b14e62482b9774ef75af50fabea80e5fc2f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TweetViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\SoftUni\TechModule\Lab\Web\SoftUniTwitter\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(74, 166, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to SoftUni\'s Twitter</h1>\r\n    <p>Create a new tweet <a href=\"/Tweets/Create\">here</a>.</p>\r\n</div>\r\n\r\n");
            EndContext();
#line 11 "D:\SoftUni\TechModule\Lab\Web\SoftUniTwitter\Views\Home\Index.cshtml"
 foreach(var tweet in Model)
{

#line default
#line hidden
            BeginContext(273, 27, true);
            WriteLiteral("    <div>\r\n        <strong>");
            EndContext();
            BeginContext(301, 14, false);
#line 14 "D:\SoftUni\TechModule\Lab\Web\SoftUniTwitter\Views\Home\Index.cshtml"
           Write(tweet.Username);

#line default
#line hidden
            EndContext();
            BeginContext(315, 20, true);
            WriteLiteral(":</strong>\r\n        ");
            EndContext();
            BeginContext(336, 20, false);
#line 15 "D:\SoftUni\TechModule\Lab\Web\SoftUniTwitter\Views\Home\Index.cshtml"
   Write(Html.Raw(tweet.Text));

#line default
#line hidden
            EndContext();
            BeginContext(356, 15, true);
            WriteLiteral("\r\n        <em>(");
            EndContext();
            BeginContext(372, 15, false);
#line 16 "D:\SoftUni\TechModule\Lab\Web\SoftUniTwitter\Views\Home\Index.cshtml"
        Write(tweet.CreatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(387, 20, true);
            WriteLiteral(")</em>\r\n    </div>\r\n");
            EndContext();
#line 18 "D:\SoftUni\TechModule\Lab\Web\SoftUniTwitter\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TweetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
