#pragma checksum "D:\projetos\Divisima\src\Divisima.API\Views\Error\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97affd9d7dbc9cb1d40d99f739111fd128b02143"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Error), @"mvc.1.0.view", @"/Views/Error/Error.cshtml")]
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
#line 1 "D:\projetos\Divisima\src\Divisima.API\Views\_ViewImports.cshtml"
using divisima;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projetos\Divisima\src\Divisima.API\Views\_ViewImports.cshtml"
using divisima.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\projetos\Divisima\src\Divisima.API\Views\_ViewImports.cshtml"
using divisima.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\projetos\Divisima\src\Divisima.API\Views\_ViewImports.cshtml"
using divisima.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\projetos\Divisima\src\Divisima.API\Views\_ViewImports.cshtml"
using divisima.API.Services.ClienteSettings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\projetos\Divisima\src\Divisima.API\Views\_ViewImports.cshtml"
using Divisima.API.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97affd9d7dbc9cb1d40d99f739111fd128b02143", @"/Views/Error/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b8c7faf229841eb4f7e780745e9518078dfe9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container-fluid\">\r\n    <h1>Erro inesperado! ");
#nullable restore
#line 2 "D:\projetos\Divisima\src\Divisima.API\Views\Error\Error.cshtml"
                    Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>");
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
