#pragma checksum "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e063a3fbd625abf16edf86432d96e6220f160460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ActivityComplete), @"mvc.1.0.view", @"/Views/Home/ActivityComplete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ActivityComplete.cshtml", typeof(AspNetCore.Views_Home_ActivityComplete))]
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
#line 1 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 2 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e063a3fbd625abf16edf86432d96e6220f160460", @"/Views/Home/ActivityComplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ActivityComplete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Activ>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml"
  
    ViewData["Title"] = "@Model.Title";

#line default
#line hidden
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 178, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n   <p class=\"lead\"> <a href=\"/Home\"> Home </a> | <a href=\"/Logout\">Logout</a>  </a></p> \r\n</div>\r\n<div class=\"row\">\r\n<h2 class=\"col-sm-10 text-left\">");
            EndContext();
            BeginContext(243, 11, false);
#line 11 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(254, 37, true);
            WriteLiteral("</h2>\r\n<hr>\r\n<div class=\"col-sm-2\">\r\n");
            EndContext();
#line 14 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml"
 if(ViewBag.Current.UserId == Model.Creator.UserId){

#line default
#line hidden
            BeginContext(345, 7, true);
            WriteLiteral("     <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 352, "\"", 384, 2);
            WriteAttributeValue("", 359, "/Cancel/", 359, 8, true);
#line 15 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml"
WriteAttributeValue("", 367, Model.ActivityId, 367, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(385, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 16 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml"
}else{


#line default
#line hidden
            BeginContext(408, 28, true);
            WriteLiteral("    <p>Leave a Rating:</p>\r\n");
            EndContext();
#line 19 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml"
}

#line default
#line hidden
            BeginContext(439, 203, true);
            WriteLiteral("</div>\r\n</div>\r\n<br><br>\r\n<div class=\"col-sm-10 text-left\">\r\n<h3>If You Enjoyed This Event Please Rate and Look Out For Other Fun Activities</h3>\r\n\r\n<h3 class=\"\">Event Coordinator:</h3>\r\n<p class=\"lead\">");
            EndContext();
            BeginContext(643, 18, false);
#line 27 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml"
           Write(Model.Creator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(661, 63, true);
            WriteLiteral("</p>\r\n\r\n<h3 class=\"\">Total Participants:</h3>\r\n<p class=\"lead\">");
            EndContext();
            BeginContext(725, 20, false);
#line 30 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml"
           Write(Model.Participants());

#line default
#line hidden
            EndContext();
            BeginContext(745, 39, true);
            WriteLiteral("</p>\r\n<h3 class=\"\">Participants:</h3>\r\n");
            EndContext();
#line 32 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml"
 foreach(var guest in @Model.Users){


#line default
#line hidden
            BeginContext(824, 21, true);
            WriteLiteral("    <p class=\"lead\"> ");
            EndContext();
            BeginContext(846, 27, false);
#line 34 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml"
                Write(guest.NavigationalUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(873, 9, true);
            WriteLiteral("</p>   \r\n");
            EndContext();
#line 35 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\ActivityComplete.cshtml"
}

#line default
#line hidden
            BeginContext(885, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Activ> Html { get; private set; }
    }
}
#pragma warning restore 1591
