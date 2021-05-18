#pragma checksum "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Shared\Components\NotificacaoComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9351254920aa28d9a8444c46b49b6472b43d2e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_NotificacaoComponent_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/NotificacaoComponent/Default.cshtml")]
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
#line 1 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\_ViewImports.cshtml"
using divisima;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\_ViewImports.cshtml"
using Divisima.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\_ViewImports.cshtml"
using Divisima.Enums.PerfilUsuarioEnums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\_ViewImports.cshtml"
using Divisima.Enums.ProdutoEnums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.Enums.ProdutoEnums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9351254920aa28d9a8444c46b49b6472b43d2e2", @"/Areas/Admin/Views/Shared/Components/NotificacaoComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca8b39603b5bf9ef6ed969afff0fd9b5b20e8b9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_NotificacaoComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<li class=""dropdown nav-item"">
    <a href=""javascript:void(0)"" class=""dropdown-toggle nav-link"" data-toggle=""dropdown"">
        <div class=""notification d-none d-lg-block d-xl-block""></div>
        <i class=""tim-icons icon-sound-wave""></i>
        <p class=""d-lg-none"">
        Notifications
        </p>
    </a>
    <ul class=""dropdown-menu dropdown-menu-right dropdown-navbar"">
");
#nullable restore
#line 12 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Shared\Components\NotificacaoComponent\Default.cshtml"
         if(Model.PedidosList.Count > 0) 
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Shared\Components\NotificacaoComponent\Default.cshtml"
             foreach (var pedidos in Model.PedidosList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-link\">\r\n                    <a href=\"#\" class=\"nav-item dropdown-item\">Pedido: ");
#nullable restore
#line 17 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Shared\Components\NotificacaoComponent\Default.cshtml"
                                                                  Write(pedidos.ValorTotal.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Shared\Components\NotificacaoComponent\Default.cshtml"
                                                                                                       Write(pedidos.Data.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n");
#nullable restore
#line 19 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Shared\Components\NotificacaoComponent\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Shared\Components\NotificacaoComponent\Default.cshtml"
             
        } 
        else 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-link\">\r\n                <a href=\"#\" class=\"nav-item dropdown-item\">Nenhuma notificação</a>\r\n            </li>\r\n");
#nullable restore
#line 26 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Shared\Components\NotificacaoComponent\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
