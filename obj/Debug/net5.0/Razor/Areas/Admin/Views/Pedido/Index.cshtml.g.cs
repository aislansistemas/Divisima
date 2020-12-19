#pragma checksum "/home/moobi/Divisima/Areas/Admin/Views/Pedido/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc9afdedc4932d0758a1d0dbebd3f8f712e77d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pedido_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Pedido/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc9afdedc4932d0758a1d0dbebd3f8f712e77d01", @"/Areas/Admin/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0e7cb9fc1418874c0d27e536fb766af725cbc50", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n  <div class=\"col-md-12\">\n    <div class=\"card \">\n      <div class=\"card-header\">\n        <h2 class=\"card-title\"> Pedidos</h2>\n      </div>\n      <div class=\"card-body\">\n        <div");
            BeginWriteAttribute("class", " class=\"", 224, "\"", 232, 0);
            EndWriteAttribute();
            WriteLiteral(">\n          <table class=\"table\"");
            BeginWriteAttribute("id", " id=\"", 265, "\"", 270, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <thead class=""text-primary"">
              <tr>
                <th>Nome do cliente</th>
                <th>Valor Total</th>
                <th>Data</th>
                <th>Pagamento Status</th>
                <th></th>
              </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/Index.cshtml"
                 foreach (var pedido in @Model.PedidosList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\n                    <td>");
#nullable restore
#line 25 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/Index.cshtml"
                   Write(pedido.Usuario.Nome.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/Index.cshtml"
                                                  Write(pedido.Usuario.Sobrenome.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 26 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/Index.cshtml"
                   Write(pedido.ValorTotal.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 27 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/Index.cshtml"
                   Write(pedido.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 28 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/Index.cshtml"
                   Write(pedido.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                      <button class=\"btn btn-warning btn-sm\">Detalhes</button>\n                    </td>\n                  </tr>\n");
#nullable restore
#line 33 "/home/moobi/Divisima/Areas/Admin/Views/Pedido/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>    \n          </table>\n          <div>\n              <button class=\"btn btn-success btn-sm\" onclick=\"carregaMaisProdutos()\">Ver Mais</button>\n          </div>\n        </div>\n      </div>\n    </div>\n</div>\n\n\n");
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
