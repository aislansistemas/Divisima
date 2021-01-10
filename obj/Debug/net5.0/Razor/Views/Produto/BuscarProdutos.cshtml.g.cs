#pragma checksum "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92cead39ec8b3de48b3309c82b978b44060ed987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_BuscarProdutos), @"mvc.1.0.view", @"/Views/Produto/BuscarProdutos.cshtml")]
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
#line 1 "D:\projetos\Divisima\Views\_ViewImports.cshtml"
using divisima;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\projetos\Divisima\Views\_ViewImports.cshtml"
using divisima.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\projetos\Divisima\Views\_ViewImports.cshtml"
using divisima.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\projetos\Divisima\Views\_ViewImports.cshtml"
using divisima.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92cead39ec8b3de48b3309c82b978b44060ed987", @"/Views/Produto/BuscarProdutos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81329903b06ff0ef882dbb34bb0d186757576cd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_BuscarProdutos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("prod-id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Ver Detalhes do Produto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- Product filter section -->\r\n\t<section class=\"product-filter-section\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"section-title mt-4\">\r\n\t\t\t\t<h2>Resultados da pesquisa (");
#nullable restore
#line 7 "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml"
                                       Write(Model.TotalProdutos);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h2>\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 11 "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml"
                 if(@Model.TotalProdutos > 0) {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml"
                     foreach(var produto in Model.Produtos) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-3 col-sm-6\">\r\n                            <div class=\"product-item\">\r\n                                <div class=\"pi-pic\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "92cead39ec8b3de48b3309c82b978b44060ed9876297", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 587, "~/", 587, 2, true);
#nullable restore
#line 16 "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml"
AddHtmlAttributeValue("", 589, Functions.GetPathUploadProdutos(), 589, 34, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 623, "/", 623, 1, true);
#nullable restore
#line 16 "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml"
AddHtmlAttributeValue("", 624, produto.Foto, 624, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <div class=""pi-links"">
                                    <a href=""#"" class=""add-card"" data-id=""1"">
                                            <i class=""flaticon-bag""></i><span>Adicionar</span>
                                        </a>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92cead39ec8b3de48b3309c82b978b44060ed9878444", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-eye icone-ver-detalhes\"></i>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml"
                                                                                   WriteLiteral(produto.ProdutoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"pi-text\">\r\n                                    <h6>");
#nullable restore
#line 27 "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml"
                                   Write(Functions.GetValorMoedaFormatado(@produto.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <p>");
#nullable restore
#line 28 "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml"
                                  Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 32 "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml"
                     
                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!-- Page info -->
                        <div class=""col-md-12 d-flex justify-content-center mb-5"">
                            <i class=""fa fa-exclamation-circle fa-3x text-warning""></i> 
                            <h2 class=""text-warning text-center ml-1 h2""> Desculpe nenhum produto foi encontrado!</h2>
                        </div>
                    <!-- Page info end -->
");
#nullable restore
#line 40 "D:\projetos\Divisima\Views\Produto\BuscarProdutos.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n<!-- Product filter section end -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProdutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
