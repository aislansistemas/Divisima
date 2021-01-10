#pragma checksum "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a14b2a729c0b95bc026a2130bd78b75f21b00e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pedido_PartialViews__detalhe), @"mvc.1.0.view", @"/Areas/Admin/Views/Pedido/PartialViews/_detalhe.cshtml")]
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
#line 1 "D:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using divisima;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using Divisima.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using Divisima.Enums.PerfilUsuarioEnums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using Divisima.Enums.ProdutoEnums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.Enums.ProdutoEnums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a14b2a729c0b95bc026a2130bd78b75f21b00e0", @"/Areas/Admin/Views/Pedido/PartialViews/_detalhe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca8b39603b5bf9ef6ed969afff0fd9b5b20e8b9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pedido_PartialViews__detalhe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
  
    var pedido = @Model.PedidoItemList.ElementAt(0);
    var usuario = pedido.Pedido.Usuario;
    var numero = @pedido.Pedido.Numero != null ? @pedido.Pedido.Numero : "Não informado";
    var Complemento = @pedido.Pedido.Complemento != null ? @pedido.Pedido.Complemento : "Não informado";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row text-dark\">\r\n        <div class=\"col-md-4\">\r\n            <ul class=\"list-unstyled\">\r\n                <li class=\"text-dark\">Nome do Usuário: ");
#nullable restore
#line 13 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                                  Write(usuario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                                                Write(usuario.Sobrenome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"text-dark\">Email: ");
#nullable restore
#line 14 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                        Write(usuario.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>  \r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <ul class=\"list-unstyled\">\r\n                <li class=\"text-dark\">CEP: ");
#nullable restore
#line 19 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                      Write(pedido.Pedido.Cep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"text-dark\">Cidade/Estado: ");
#nullable restore
#line 20 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                                Write(pedido.Pedido.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 20 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                                                      Write(pedido.Pedido.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"text-dark\">Bairro: ");
#nullable restore
#line 21 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                         Write(pedido.Pedido.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"text-dark\">Endereco: ");
#nullable restore
#line 22 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                           Write(pedido.Pedido.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"text-dark\">Numero: ");
#nullable restore
#line 23 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                         Write(numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"text-dark\">Complemento: ");
#nullable restore
#line 24 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                              Write(Complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>  \r\n        </div>  \r\n        <div class=\"col-md-4\">\r\n            <ul class=\"list-unstyled\">\r\n                <li class=\"text-dark\">Status:  ");
#nullable restore
#line 29 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                          Write(pedido.Pedido.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"text-dark\">Entregue:  ");
#nullable restore
#line 30 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                            Write(pedido.Pedido.Entregue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"text-dark\">Data da compra: ");
#nullable restore
#line 31 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                                 Write(pedido.Pedido.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"text-dark\">Valor total: ");
#nullable restore
#line 32 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                              Write(pedido.Pedido.ValorTotal.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>  \r\n        </div>\r\n        <div class=\"col-md-12\">\r\n            <h4 class=\"text-dark\">Itens do pedido</h4>\r\n            <table class=\"table table-dark\"");
            BeginWriteAttribute("id", " id=\"", 1799, "\"", 1804, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""border-radius: 8px;"">
                <thead class=""text-primary"">
                <tr>
                    <th></th>
                    <th class=""text-primary"">Produto</th>
                    <th class=""text-primary"">Valor</th>
                    <th class=""text-primary"">Quantidade</th>
                    <th class=""text-primary"">Tamanho</th>
                </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 48 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                     foreach (var pedidoItem in @Model.PedidoItemList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-dark\">\r\n                                \r\n                            </td>\r\n                            <td class=\"text-dark\">");
#nullable restore
#line 54 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                             Write(pedidoItem.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-dark\">");
#nullable restore
#line 55 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                             Write(pedidoItem.Produto.Valor.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-dark\">");
#nullable restore
#line 56 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                             Write(pedidoItem.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-dark\">");
#nullable restore
#line 57 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                                             Write(pedidoItem.Tamanho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>  \r\n");
#nullable restore
#line 59 "D:\projetos\Divisima\Areas\Admin\Views\Pedido\PartialViews\_detalhe.cshtml"
                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>    \r\n            </table>\r\n        </div>         \r\n    </div>\r\n</div>");
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
