#pragma checksum "D:\projetos\Divisima\src\Divisima.API\Views\Produto\ProdutosPorCategoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "744982421a243cab18083a77933e7b28e323669e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744982421a243cab18083a77933e7b28e323669e", @"/Views/Produto/ProdutosPorCategoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b8c7faf229841eb4f7e780745e9518078dfe9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_ProdutosPorCategoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoriaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Product filter section -->\r\n\t<section class=\"product-filter-section mt-5\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"section-title\">\r\n\t\t\t\t<h2 class=\"titulo-categoria\">");
#nullable restore
#line 6 "D:\projetos\Divisima\src\Divisima.API\Views\Produto\ProdutosPorCategoria.cshtml"
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
<!--- modal carregamento ---");
            WriteLiteral(">\r\n<div>\r\n\t<input type=\"hidden\" id=\"input-categoria-id\"");
            BeginWriteAttribute("value", " value=\"", 1300, "\"", 1336, 1);
#nullable restore
#line 33 "D:\projetos\Divisima\src\Divisima.API\Views\Produto\ProdutosPorCategoria.cshtml"
WriteAttributeValue("", 1308, Model.Categoria.CategoriaId, 1308, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>");
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
