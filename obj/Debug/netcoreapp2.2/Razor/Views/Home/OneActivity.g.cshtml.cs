#pragma checksum "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61616130de4bcf2e2dab409b2e6f711715de07db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneActivity), @"mvc.1.0.view", @"/Views/Home/OneActivity.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/OneActivity.cshtml", typeof(AspNetCore.Views_Home_OneActivity))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61616130de4bcf2e2dab409b2e6f711715de07db", @"/Views/Home/OneActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Activ>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
  
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
#line 11 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(254, 37, true);
            WriteLiteral("</h2>\r\n<hr>\r\n<div class=\"col-sm-2\">\r\n");
            EndContext();
#line 14 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
 if(ViewBag.Current.UserId == Model.Creator.UserId){

#line default
#line hidden
            BeginContext(345, 7, true);
            WriteLiteral("     <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 352, "\"", 384, 2);
            WriteAttributeValue("", 359, "/Cancel/", 359, 8, true);
#line 15 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
WriteAttributeValue("", 367, Model.ActivityId, 367, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(385, 13, true);
            WriteLiteral(">Cancel</a>\r\n");
            EndContext();
#line 16 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
}else{

    
        

#line default
#line hidden
#line 19 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
         if(Model.Users.All( u => u.NavigationalUser.UserId != ViewBag.Current.UserId)){

#line default
#line hidden
            BeginContext(504, 15, true);
            WriteLiteral("             <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 519, "\"", 549, 2);
            WriteAttributeValue("", 526, "/Join/", 526, 6, true);
#line 20 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
WriteAttributeValue("", 532, Model.ActivityId, 532, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(550, 11, true);
            WriteLiteral(">Join</a>\r\n");
            EndContext();
#line 21 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
        }else{

#line default
#line hidden
            BeginContext(577, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 591, "\"", 622, 2);
            WriteAttributeValue("", 598, "/Leave/", 598, 7, true);
#line 22 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
WriteAttributeValue("", 605, Model.ActivityId, 605, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(623, 12, true);
            WriteLiteral(">Leave</a>\r\n");
            EndContext();
#line 23 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
}

#line default
#line hidden
#line 23 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
 }

#line default
#line hidden
            BeginContext(639, 93, true);
            WriteLiteral("</div>\r\n</div>\r\n<br><br>\r\n<div class=\"col-sm-10 text-left\">\r\n<h3>When:</h3>\r\n<p class=\"lead\">");
            EndContext();
            BeginContext(733, 29, false);
#line 29 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
           Write(Model.Date.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(762, 38, true);
            WriteLiteral("</p>\r\n<h3>Time:</h3>\r\n<p class=\"lead\">");
            EndContext();
            BeginContext(801, 30, false);
#line 31 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
           Write(Model.Time.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(831, 60, true);
            WriteLiteral("</p>\r\n<h3 class=\"\">Event Coordinator:</h3>\r\n<p class=\"lead\">");
            EndContext();
            BeginContext(892, 18, false);
#line 33 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
           Write(Model.Creator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(910, 54, true);
            WriteLiteral("</p>\r\n<h3 class=\"\">Description:</h3>\r\n<p class=\"lead\">");
            EndContext();
            BeginContext(965, 17, false);
#line 35 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(982, 63, true);
            WriteLiteral("</p>\r\n\r\n<h3 class=\"\">Total Participants:</h3>\r\n<p class=\"lead\">");
            EndContext();
            BeginContext(1046, 20, false);
#line 38 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
           Write(Model.Participants());

#line default
#line hidden
            EndContext();
            BeginContext(1066, 39, true);
            WriteLiteral("</p>\r\n<h3 class=\"\">Participants:</h3>\r\n");
            EndContext();
#line 40 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
 foreach(var guest in @Model.Users){


#line default
#line hidden
            BeginContext(1145, 21, true);
            WriteLiteral("    <p class=\"lead\"> ");
            EndContext();
            BeginContext(1167, 27, false);
#line 42 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"
                Write(guest.NavigationalUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1194, 9, true);
            WriteLiteral("</p>   \r\n");
            EndContext();
#line 43 "C:\Users\Carlo\Documents\Coding_Dojo\c\csharp\ORM\Entity\New folder\ActivityCenter\Views\Home\OneActivity.cshtml"

}

#line default
#line hidden
            BeginContext(1208, 6, true);
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
