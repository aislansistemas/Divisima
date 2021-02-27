#pragma checksum "d:\projetos\Divisima\Areas\Admin\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "196fd57b44ed8811bedda2f1144226f41542e524"
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
#line 1 "d:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using divisima;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using Divisima.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using Divisima.Enums.PerfilUsuarioEnums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using Divisima.Enums.ProdutoEnums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\projetos\Divisima\Areas\Admin\Views\_ViewImports.cshtml"
using divisima.Enums.ProdutoEnums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"196fd57b44ed8811bedda2f1144226f41542e524", @"/Areas/Admin/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca8b39603b5bf9ef6ed969afff0fd9b5b20e8b9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n  <div class=\"col-md-12\">\r\n    <div class=\"card \">\r\n      <div class=\"card-header\">\r\n        <h2 class=\"card-title\"> Pedidos</h2>\r\n      </div>\r\n      <div class=\"card-body\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 209, "\"", 217, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n          <table class=\"table\"");
            BeginWriteAttribute("id", " id=\"", 251, "\"", 256, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <thead class=""text-primary"">
              <tr>
                <th>Nome do cliente</th>
                <th>Valor Total</th>
                <th>Data</th>
                <th>Pagamento Status</th>
                <th>Entregue</th>
                <th></th>
              </tr>
            </thead>
            <tbody id=""lista-pedidos"">
               
            </tbody>    
          </table>
          <div>
              <button class=""btn btn-success btn-sm"" onclick=""carregaMaisProdutos()"">Ver Mais</button>
          </div>
        </div>
      </div>
    </div>
</div>

<!-- Modal Detalhes -->
<div class=""modal fade"" id=""modal-detalhe-pedido"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
  <div class=""modal-dialog modal-xl"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title font-weight-bold"" id=""exampleModalLongTitle"">Detalhes do Pedido</h5>
        <button typ");
            WriteLiteral(@"e=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"" id=detalhes-pedido>
      
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
      </div>
    </div>
  </div>
</div>
<!-- Fim Modal detalhes -->


");
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
