#pragma checksum "\Views\Account\ExternalLoginFailure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "714d282c35463e1daaccd937296f5b85f143b9ea"
namespace MusicStore.Views.Account
{
#line 1 "/Views/_ViewImports.cshtml"
using MusicStore

#line default
#line hidden
    ;
#line 2 "/Views/_ViewImports.cshtml"
using MusicStore.Models

#line default
#line hidden
    ;
#line 3 "/Views/_ViewImports.cshtml"
using Microsoft.Extensions.Options

#line default
#line hidden
    ;
#line 4 "/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity

#line default
#line hidden
    ;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System.Threading.Tasks;

    public class ExternalLoginFailure : Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        public ExternalLoginFailure()
        {
        }
        #line hidden
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }

        #line hidden

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
#line 1 "\Views\Account\ExternalLoginFailure.cshtml"
  
    ViewBag.Title = "Login Failure";

#line default
#line hidden

            BeginContext(45, 20, true);
            WriteLiteral("\r\n<hgroup>\r\n    <h2>");
            EndContext();
            BeginContext(66, 13, false);
#line 6 "\Views\Account\ExternalLoginFailure.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(79, 84, true);
            WriteLiteral(".</h2>\r\n    <h3 class=\"text-danger\">Unsuccessful login with service.</h3>\r\n</hgroup>");
            EndContext();
        }
        #pragma warning restore 1998
    }
}