#pragma checksum "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c57dbb2da3c8718c78e1142eff80107d25c3cf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Produto_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Produto/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c57dbb2da3c8718c78e1142eff80107d25c3cf4", @"/Areas/Admin/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca8b39603b5bf9ef6ed969afff0fd9b5b20e8b9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-cadastro-produto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-edit-produto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""row"">
  <div class=""col-md-12"">
    <div class=""card "">
      <div class=""card-header"">
        <h2 class=""card-title""> Produtos</h2>
      </div>
      <div class=""card-body"">
        <!-- Botão para acionar modal -->
        <button type=""button"" class=""btn btn-info"" data-toggle=""modal"" data-target=""#modal-cadastrar"">
          <i class=""tim-icons icon-simple-add""></i> Novo 
        </button>
        <!-- Fim Botão para acionar modal -->
        
        <div");
            BeginWriteAttribute("class", " class=\"", 494, "\"", 502, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n          <table class=\"table\"");
            BeginWriteAttribute("id", " id=\"", 536, "\"", 541, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <thead class=""text-primary"">
              <tr>
                <th>Nome</th>
                <th>Quantidade</th>
                <th>Valor</th>
                <th></th>
              </tr>
            </thead>
            <tbody id=""tabela-list-produto"">
             
            </tbody>    
          </table>
          <div>
              <button class=""btn btn-success btn-sm"" onclick=""carregaMaisProdutos()"">Ver Mais</button>
          </div>
        </div>
      </div>
    </div>
</div>
    
<!-- Modal cadastrar -->
<div class=""modal fade"" id=""modal-cadastrar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-xl"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Cadastrar Produto</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
          <span aria-hidden=""true"">&times;<");
            WriteLiteral("/span>\r\n        </button>\r\n      </div>\r\n      <div class=\"modal-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c57dbb2da3c8718c78e1142eff80107d25c3cf49542", async() => {
                WriteLiteral(@"
          <div class=""row"">
            <div class=""col-md-6"">
              <div class=""form-group"">
                <label for=""nome-produto"">Nome do Produto<span class=""text-danger"">*</span></label>
                <input class=""form-control text-dark nome-categoria"" type=""text"" name=""Nome"" autocomplete=""false"">
                <span class=""text-danger validate-nome""></span>
              </div>
            </div> 
            <div class=""col-md-6"">   
              <div class=""form-group"">
                <label for=""descricao-produto"">Descrição</label>
                <input class=""form-control text-dark nome-categoria"" type=""text"" name=""Descricao"" autocomplete=""false"">
              </div>
            </div>
            <div class=""col-md-2"">
              <div class=""form-group"">
                <label for=""descricao-produto"">Valor<span class=""text-danger"">*</span></label>
                <input class=""form-control text-dark nome-categoria"" type=""text"" name=""Valor"" autocomplete=""fals");
                WriteLiteral(@"e"">
                <span class=""text-danger validate-valor""></span>
              </div>
            </div>
            <div class=""col-md-2"">
              <div class=""form-group"">
                <label for=""descricao-produto"">Quantidade<span class=""text-danger"">*</span></label>
                <input class=""form-control text-dark nome-categoria"" type=""number"" name=""Quantidade"" autocomplete=""false"">
                <span class=""text-danger validate-quantidade""></span>
              </div>
            </div> 
            <div class=""col-md-2""> 
              <div class=""form-group"">
                <label for=""descricao-produto"">Tamanho<span class=""text-danger"">*</span></label>
                <select class=""form-control text-dark"" name=""Tamanho"">
");
#nullable restore
#line 82 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Produto\Index.cshtml"
                   foreach (var item in ProdutoTamanhoEnumClass.GetComboEnum())
                  {

#line default
#line hidden
#nullable disable
                WriteLiteral("                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c57dbb2da3c8718c78e1142eff80107d25c3cf412031", async() => {
#nullable restore
#line 84 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Produto\Index.cshtml"
                                                             Write(item.Value);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Produto\Index.cshtml"
                         WriteLiteral(item.Key);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 85 "D:\projetos\Divisima\src\Divisima.API\Areas\Admin\Views\Produto\Index.cshtml"
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
                <span class=""text-danger validate-tamanho""></span>
              </div>
            </div>
            <div class=""col-md-3""> 
              <label>Categoria<span class=""text-danger"">*</span></label>
              <span class=""text-danger validate-categoria""></span>
              <select class=""form-control text-dark categoria-produto"" id=""select-categorias"" name=""CategoriaId"">
              </select>
            </div>
            <div id=""div-campos-foto-clone"" class=""col-md-4"" style=""border: 1px solid #dedede;""> 
              <label>Foto<span class=""text-danger"">*</span></label>
              <input class=""form-control"" type=""file"" name=""Foto"" multiple=""true"">
              <span class=""text-danger validate-foto""></span>
            </div>
            <!---<div class=""row"" id=""fotos-incluidas-input"">

            </div>
            <div class=""col-md-2"">
              <button id=""btn-adicionar-inputs-foto"" class=""btn btn-sucess btn-sm"" title=""Ad");
                WriteLiteral("icionar mais fotos\">\r\n                <i class=\"tim-icons icon-simple-add\"></i>\r\n              </button>\r\n            </div>------>\r\n          </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
        <button type=""button"" class=""btn btn-primary"" onclick=""cadastrarProduto()"">Cadastrar</button>
      </div>
    </div>
  </div>
</div>
<!-- Fim Modal cadastrar -->

<!-- Modal Detalhes -->
<div class=""modal fade"" id=""modal-detalhe-produto"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title font-weight-bold"" id=""exampleModalLongTitle"">Detalhes do Produto</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <div class=""row"">
          <div class=""col-md-7 border-right"">
            <div class=""col-md-12"">
        ");
            WriteLiteral(@"      <h5 class=""text-dark"">Nome: <span class=""text-name-produto text-info""></span></h5>
            </div>
            <div class=""col-md-12"">
              <h5 class=""text-dark"">Descrição: <span class=""text-descricao-produto text-info""></span></h5>
            </div>
            <div class=""col-md-12"">
              <h5 class=""text-dark"">Quantidade: <span class=""text-quantidade-produto text-info""></span></h5>
            </div>
            <div class=""col-md-12"">
              <h5 class=""text-dark"">Valor: <span class=""text-valor-produto text-info""></span></h5>
            </div>
            <div class=""col-md-12"">
              <h5 class=""text-dark"">Tamanho: <span class=""text-tamanho-produto text-info""></span></h5>
            </div>
            <div class=""col-md-12"">
              <h5 class=""text-dark"">Categoria: <span class=""text-categoria-produto text-info""></span></h5>
            </div>
          </div>
          <div class=""col-md-5"">
            <img class=""foto-detalhe-produto im");
            WriteLiteral(@"g-fluid"">
          </div>
        </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
      </div>
    </div>
  </div>
</div>
<!-- Fim Modal detalhes -->

<!-- Modal editar-->
<div class=""modal fade"" id=""modalEdit"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-xl"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Editar</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c57dbb2da3c8718c78e1142eff80107d25c3cf419594", async() => {
                WriteLiteral(@"
          <div class=""row"">
            <div class=""col-md-6"">
                <input type=""hidden"" class=""id-produto"" name=""ProdutoId"">
              <div class=""form-group"">
                <label for=""nome-produto"">Nome do Produto<span class=""text-danger"">*</span></label>
                <input class=""form-control text-dark nome-produto"" type=""text"" name=""Nome"" autocomplete=""false"">
                <span class=""text-danger validate-nome""></span>
              </div>
            </div> 
            <div class=""col-md-6"">   
              <div class=""form-group"">
                <label for=""descricao-produto"">Descrição</label>
                <input class=""form-control text-dark descricao-produto"" type=""text"" name=""Descricao"" autocomplete=""false"">
                <span class=""text-danger validate-nome""></span>
              </div>
            </div>
            <div class=""col-md-2"">
              <div class=""form-group"">
                <label for=""descricao-produto"">Valor</label>
     ");
                WriteLiteral(@"           <input class=""form-control text-dark valor-produto"" type=""text"" name=""Valor"" autocomplete=""false"">
                <span class=""text-danger validate-nome""></span>
              </div>
            </div>
            <div class=""col-md-2"">
              <div class=""form-group"">
                <label for=""descricao-produto"">Quantidade</label>
                <input class=""form-control text-dark quantidade-produto"" type=""number"" name=""Quantidade"" autocomplete=""false"">
                <span class=""text-danger validate-nome""></span>
              </div>
            </div> 
            <div class=""col-md-2""> 
              <div class=""form-group"">
                <label for=""descricao-produto"">Tamanho</label>
                <select class=""form-control tamanho-produto text-dark"" name=""Tamanho"">
                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c57dbb2da3c8718c78e1142eff80107d25c3cf421838", async() => {
                    WriteLiteral("PP");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c57dbb2da3c8718c78e1142eff80107d25c3cf423163", async() => {
                    WriteLiteral("P");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c57dbb2da3c8718c78e1142eff80107d25c3cf424487", async() => {
                    WriteLiteral("M");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c57dbb2da3c8718c78e1142eff80107d25c3cf425811", async() => {
                    WriteLiteral("G");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c57dbb2da3c8718c78e1142eff80107d25c3cf427135", async() => {
                    WriteLiteral("GG");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c57dbb2da3c8718c78e1142eff80107d25c3cf428460", async() => {
                    WriteLiteral("Extra G");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </select>
                <span class=""text-danger validate-nome""></span>
              </div>
            </div> 
            <div class=""col-md-3""> 
              <label>Categoria<span class=""text-danger"">*</span></label>
              <span class=""text-danger validate-categoria""></span>
              <select class=""form-control text-dark categoria-produto"" name=""CategoriaId"">
              </select>
            </div>
            <div class=""col-md-3""> 
              <label>Foto<span class=""text-danger"">*</span></label>
              <input class=""form-control foto-produto"" type=""file"" id=""foto"" name=""Foto"">
               <span class=""text-danger validate-foto""></span>
            </div>  
          </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
        <button type=""button"" class=""btn btn-primary"" onclick=""editarProduto()"">Editar</button>
      </div>
    </div>
  </div>
</div>
<!-- Fim Modal editar -->

<!-- Modal delete-->
<div class=""modal fade"" id=""modalDelete"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog modal-sm"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Tem certeza que deseja Deletar este produto?</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c57dbb2da3c8718c78e1142eff80107d25c3cf432561", async() => {
                WriteLiteral("\r\n          <input type=\"hidden\" class=\"id-produto\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
        <button type=""button"" class=""btn btn-danger"" onclick=""deletarProduto()"">Deletar</button>
      </div>
    </div>
  </div>
</div>
<!-- Fim Modal delete -->
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