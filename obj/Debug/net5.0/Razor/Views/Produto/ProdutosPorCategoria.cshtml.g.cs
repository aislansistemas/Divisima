#pragma checksum "/home/moobi/Divisima/Views/Produto/ProdutosPorCategoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "820b6085772b47009a3f00f12c41d1263ba701d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_ProdutosPorCategoria), @"mvc.1.0.view", @"/Views/Produto/ProdutosPorCategoria.cshtml")]
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
#line 1 "/home/moobi/Divisima/Views/_ViewImports.cshtml"
using divisima;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/moobi/Divisima/Views/_ViewImports.cshtml"
using divisima.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/moobi/Divisima/Views/_ViewImports.cshtml"
using divisima.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"820b6085772b47009a3f00f12c41d1263ba701d2", @"/Views/Produto/ProdutosPorCategoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09967dfe9b254561ecab6a27903e8c8e6697c712", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_ProdutosPorCategoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoriaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Product filter section -->\n\t<section class=\"product-filter-section mt-5\">\n\t\t<div class=\"container\">\n\t\t\t<div class=\"section-title\">\n\t\t\t\t<h2 class=\"titulo-categoria\">");
#nullable restore
#line 6 "/home/moobi/Divisima/Views/Produto/ProdutosPorCategoria.cshtml"
                                        Write(Model.Categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
			</div>
			<!---lista produtos---->
			<div class=""row row-all-products-por-categoria"">	
				<!-------------------->	
			</div>
			<!---lista produtos---->
			<div class=""text-center pt-5"">
				<button class=""site-btn sb-line sb-dark btn-ver-mais"" onclick=""carregarMaisProdutosPorCategoria()"" data-toggle=""modal"" data-target=""#modal-carregamento"">Ver mais</button>
			</div>
		</div>
	</section>
<!-- Product filter section end -->

<!--- modal carregamento --->
    <div class=""modal"" id=""modal-carregamento"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered "" role=""document"">
            <div class=""modal-content"">		
            <div class=""modal-body"">
            
            </div>
                <button style=""display: none"" type=""button"" class=""btn btn-secondary btn-close-modal"" data-dismiss=""modal""></button>
            </div>
        </div>
    </div>
<!--- modal carregamento --->
<div>
	<input type=""hid");
            WriteLiteral("den\" id=\"input-categoria-id\"");
            BeginWriteAttribute("value", " value=\"", 1268, "\"", 1304, 1);
#nullable restore
#line 33 "/home/moobi/Divisima/Views/Produto/ProdutosPorCategoria.cshtml"
WriteAttributeValue("", 1276, Model.Categoria.CategoriaId, 1276, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoriaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591