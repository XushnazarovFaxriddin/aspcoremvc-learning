#pragma checksum "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7f969dbb59ea24116b49c918f6170d76fad5ebd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7f969dbb59ea24116b49c918f6170d76fad5ebd", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPNETCoreApp1.ViewModels.HomeDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Details.cshtml"
   
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Details Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 8 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Details.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div>\r\n    Name: ");
#nullable restore
#line 10 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Details.cshtml"
     Write(Model.Staff.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Details.cshtml"
                            Write(Model.Staff.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Email: ");
#nullable restore
#line 13 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Details.cshtml"
      Write(Model.Staff.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Department: ");
#nullable restore
#line 16 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Details.cshtml"
           Write(Model.Staff.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPNETCoreApp1.ViewModels.HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
