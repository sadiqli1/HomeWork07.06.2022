#pragma checksum "C:\Users\isasa\Desktop\BackEnd\WebApplication9\WebApplication9\Views\Home\ServiceDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b62e29f43599d7db6908d9e742b1e9bcc1fb430f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ServiceDetail), @"mvc.1.0.view", @"/Views/Home/ServiceDetail.cshtml")]
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
#line 1 "C:\Users\isasa\Desktop\BackEnd\WebApplication9\WebApplication9\Views\_ViewImports.cshtml"
using WebApplication9.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b62e29f43599d7db6908d9e742b1e9bcc1fb430f", @"/Views/Home/ServiceDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfb8b75dae1d9faf4d9c82e5a3363cb75b772620", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ServiceDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Service>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\">\r\n            <div class=\"icon-box\" data-aos=\"fade-up\" data-aos-delay=\"100\">\r\n              <div class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 201, "\"", 223, 2);
            WriteAttributeValue("", 209, "bx", 209, 2, true);
#nullable restore
#line 5 "C:\Users\isasa\Desktop\BackEnd\WebApplication9\WebApplication9\Views\Home\ServiceDetail.cshtml"
WriteAttributeValue(" ", 211, Model.Icon, 212, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></div>\r\n              <h4 class=\"title\"><a\">");
#nullable restore
#line 6 "C:\Users\isasa\Desktop\BackEnd\WebApplication9\WebApplication9\Views\Home\ServiceDetail.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n              <p class=\"description\">");
#nullable restore
#line 7 "C:\Users\isasa\Desktop\BackEnd\WebApplication9\WebApplication9\Views\Home\ServiceDetail.cshtml"
                                Write(Model.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n          </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Service> Html { get; private set; }
    }
}
#pragma warning restore 1591
