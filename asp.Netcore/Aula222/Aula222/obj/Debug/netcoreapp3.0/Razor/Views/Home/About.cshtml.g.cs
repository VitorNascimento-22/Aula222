#pragma checksum "C:\Users\vitor.nascimento\Documents\estudo\asp.Netcore\Aula222\Aula222\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1b485c491f390e28a69c9f40db87141fba2e26e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\vitor.nascimento\Documents\estudo\asp.Netcore\Aula222\Aula222\Views\_ViewImports.cshtml"
using Aula222;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vitor.nascimento\Documents\estudo\asp.Netcore\Aula222\Aula222\Views\_ViewImports.cshtml"
using Aula222.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1b485c491f390e28a69c9f40db87141fba2e26e", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ede9c16561ea96f1320243368504656adc252a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\vitor.nascimento\Documents\estudo\asp.Netcore\Aula222\Aula222\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 5 "C:\Users\vitor.nascimento\Documents\estudo\asp.Netcore\Aula222\Aula222\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 6 "C:\Users\vitor.nascimento\Documents\estudo\asp.Netcore\Aula222\Aula222\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<p>Aluno: ");
#nullable restore
#line 8 "C:\Users\vitor.nascimento\Documents\estudo\asp.Netcore\Aula222\Aula222\Views\Home\About.cshtml"
     Write(ViewData["Aluno"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<address>\r\n    <strong>More information: </strong><a href=\"http://google.com\"> Google.com </a>\r\n</address>\r\n<p>");
#nullable restore
#line 13 "C:\Users\vitor.nascimento\Documents\estudo\asp.Netcore\Aula222\Aula222\Views\Home\About.cshtml"
Write(ViewData["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
