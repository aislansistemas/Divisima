#pragma checksum "/home/moobi/Divisima/Areas/Admin/Views/Categoria/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fc0185e88a6baeb3fcb3c8b84a6ec03b951c08b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categoria_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Categoria/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fc0185e88a6baeb3fcb3c8b84a6ec03b951c08b", @"/Areas/Admin/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fc5079621a4072d83e7c8199e1d109ba3714a50", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
  <div class=""col-md-12"">
    <div class=""card "">
      <div class=""card-header"">
        <h2 class=""card-title""> Categorias</h2>
      </div>
      <div class=""card-body"">
        <!-- Botão para acionar modal -->
        <button type=""button"" class=""btn btn-info"" data-toggle=""modal"" data-target=""#ExemploModalCentralizado"">
          <i class=""tim-icons icon-simple-add""></i> Nova 
        </button>
        <!-- Fim Botão para acionar modal -->
        
        <div");
            BeginWriteAttribute("class", " class=\"", 488, "\"", 496, 0);
            EndWriteAttribute();
            WriteLiteral(">\n          <table class=\"table table-hover\"");
            BeginWriteAttribute("id", " id=\"", 541, "\"", 546, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <thead class=""text-primary"">
              <tr>
                <th>
                  Nome
                </th>
                <th>
                  Status
                </th>
                <th></th>
                <th></th>
              </tr>
            </thead>
            <tbody id=""tabela-list-categoria"">
             
            </tbody>
          </table>
        </div>
      </div>
    </div>
</div>

<!-- Modal cadastrar -->
<div style=""margin-top: -400px"" class=""modal fade"" id=""ExemploModalCentralizado"" tabindex=""-1"" role=""dialog"" aria-labelledby=""TituloModalCentralizado"" aria-hidden=""true"">
  <div class=""modal-dialog modal-dialog-centered"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"" id=""TituloModalCentralizado"">Cadastrar nova Categoria</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
 ");
            WriteLiteral(@"     <div class=""modal-body"">
        <input type=""hidden"" name=""categoriaId"" id=""id-categoria"">
        <label for=""nome-categoria"">Nome da Categoria</label>
        <input class=""form-control text-dark nome-categoria"" type=""text"" name=""Nome"" autocomplete=""false"">
        <span class=""text-danger validate-nome""></span>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
        <button type=""button"" class=""btn btn-primary"" id=""btn-cad-categoria"">Salvar mudanças</button>
      </div>
    </div>
  </div>
</div>
<!-- Fim Modal cadastrar -->

<!-- Modal editar-->
<div style=""margin-top: -400px"" class=""modal fade"" id=""ModalCentralizadoEditar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""TituloModalCentralizado"" aria-hidden=""true"">
  <div class=""modal-dialog modal-dialog-centered"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"" id=""TituloModalCentralizado"">Editar<");
            WriteLiteral(@"/h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <input type=""hidden"" class=""id-categoria"" name=""categoriaId"">
        <label for=""nome-categoria"">Nome da Categoria</label>
        <input class=""form-control text-dark nome-categoria"" type=""text"" name=""Nome"" autocomplete=""false"">
        <span class=""text-danger validate-nome""></span>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
        <button type=""button"" class=""btn btn-primary"" id=""btn-edit-categoria"">Editar</button>
      </div>
    </div>
  </div>
</div>
<!-- Fim Modal editar -->

<!-- Modal inativar-->
<div style=""margin-top: -400px"" class=""modal fade"" id=""ModalCentralizadoInativar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""TituloModalCentralizado"" aria-hidden=""true"">
  <div class=""modal-dialog moda");
            WriteLiteral(@"l-dialog-centered"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"" id=""TituloModalCentralizado"">Tem certeza que deseja inativar essa categoria?</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <input type=""hidden"" class=""id-categoria"" name=""categoriaId"">
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
        <button type=""button"" class=""btn btn-success"" id=""btn-inat-categoria"">Confirmar</button>
      </div>
    </div>
  </div>
</div>
<!-- Fim Modal inativar -->

<!-- Modal Ativar-->
<div style=""margin-top: -400px"" class=""modal fade"" id=""ModalCentralizadoAtivar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""TituloModalCentralizado"" aria-hidden=""true"">
  <div class=""modal-dialog modal-dialog-cente");
            WriteLiteral(@"red"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title"" id=""TituloModalCentralizado"">Tem certeza que deseja ativar essa categoria?</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <input type=""hidden"" class=""id-categoria"" name=""categoriaId"">
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
        <button type=""button"" class=""btn btn-success"" id=""btn-ativ-categoria"">Confirmar</button>
      </div>
    </div>
  </div>
</div>
<!-- Fim Modal Ativar -->




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
