#pragma checksum "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Ruyhat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f38ce39d7270eef764d015bd3fd935011d0e708c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ruyhat), @"mvc.1.0.view", @"/Views/Home/Ruyhat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f38ce39d7270eef764d015bd3fd935011d0e708c", @"/Views/Home/Ruyhat.cshtml")]
    public class Views_Home_Ruyhat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f38ce39d7270eef764d015bd3fd935011d0e708c2719", async() => {
                WriteLiteral("\r\n\t<title></title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f38ce39d7270eef764d015bd3fd935011d0e708c3706", async() => {
                WriteLiteral("\r\n\t<h3>");
#nullable restore
#line 6 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Ruyhat.cshtml"
   Write(ViewBag.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 7 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Ruyhat.cshtml"
      
		var staff = ViewData["staff"] as List<ASPNETCoreApp1.Models.Staff>;
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Ruyhat.cshtml"
     for(int i=0; i<3; i++){
		if (staff[i] == null) return;

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<div>\r\n\t\tName: ");
#nullable restore
#line 13 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Ruyhat.cshtml"
         Write(staff[i].FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 13 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Ruyhat.cshtml"
                             Write(staff[i].LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t</div>\r\n\t<div>\r\n\t\tEmail: ");
#nullable restore
#line 16 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Ruyhat.cshtml"
          Write(staff[i].Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t</div>\r\n\t<div>\r\n\t\tDepartment: ");
#nullable restore
#line 19 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Ruyhat.cshtml"
               Write(staff[i].Department);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t</div>\r\n\t<br/>\r\n");
#nullable restore
#line 22 "E:\.NET\aspcoremvc-learning\ASPNETCoreApp1\Views\Home\Ruyhat.cshtml"
	}

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>");
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
