#pragma checksum "/home/moobi/Divisima/Areas/Admin/Views/Pedido/PartialViews/_carregar-pedidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0493c8e9bee6555ca9238875b159c7556f443de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pedido_PartialViews__carregar_pedidos), @"mvc.1.0.view", @"/Areas/Admin/Views/Pedido/PartialViews/_carregar-pedidos.cshtml")]
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
#line 1 "/home/moobi/Divisima/Areas/Admin/Views/_ViewImports.cshtml"
using divisima;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/moobi/Divisima/Areas/Admin/Views/_ViewImports.cshtml"
using divisima.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/moobi/Divisima/Areas/Admin/Views/_ViewImports.cshtml"
using divisima.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/moobi/Divisima/Areas/Admin/Views/_ViewImports.cshtml"
using Divisima.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/moobi/Divisima/Areas/Admin/Views/_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/moobi/Divisima/Areas/Admin/Views/_ViewImports.cshtml"
using divisima.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0493c8e9bee6555ca9238875b159c7556f443de", @"/Areas/Admin/Views/Pedido/PartialViews/_carregar-pedidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fc5079621a4072d83e7c8199e1d109ba3714a50", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pedido_PartialViews__carregar_pedidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/PartialViews/_carregar-pedidos.cshtml"
 foreach (var pedido in @Model.PedidosList)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\n    <td>");
#nullable restore
#line 6 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/PartialViews/_carregar-pedidos.cshtml"
   Write(pedido.Usuario.Nome.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/PartialViews/_carregar-pedidos.cshtml"
                                  Write(pedido.Usuario.Sobrenome.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 7 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/PartialViews/_carregar-pedidos.cshtml"
   Write(pedido.ValorTotal.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 8 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/PartialViews/_carregar-pedidos.cshtml"
   Write(pedido.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 9 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/PartialViews/_carregar-pedidos.cshtml"
   Write(pedido.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n      <button");
            BeginWriteAttribute("onclick", " onclick=\"", 280, "\"", 326, 3);
            WriteAttributeValue("", 290, "vizualizarDetalhes(", 290, 19, true);
#nullable restore
#line 11 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/PartialViews/_carregar-pedidos.cshtml"
WriteAttributeValue("", 309, pedido.PedidoId, 309, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 325, ")", 325, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#modal-detalhe-pedido\" class=\"btn btn-warning btn-sm\">Detalhes</button>\n    </td>\n  </tr>\n");
#nullable restore
#line 14 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/PartialViews/_carregar-pedidos.cshtml"
}

#line default
#line hidden
#nullable disable
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
