#pragma checksum "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddf34da20db10c90e576463182e2c0dc29e59779"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarrinhoCompra_Index), @"mvc.1.0.view", @"/Views/CarrinhoCompra/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddf34da20db10c90e576463182e2c0dc29e59779", @"/Views/CarrinhoCompra/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09967dfe9b254561ecab6a27903e8c8e6697c712", @"/Views/_ViewImports.cshtml")]
    public class Views_CarrinhoCompra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarrinhoCompraViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("site-btn sb-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-remove-carrinho-id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\t<!-- Page info -->\n\t<div class=\"page-top-info\">\n\t\t\n\t</div>\n\t<!-- Page info end -->\n\n\t<!-- cart section end -->\n\t<section class=\"cart-section spad\">\n\t\t<div class=\"container\">\n\t\t\t<div class=\"row\">\n\t\t\t\t<div class=\"col-lg-8\">\n\n");
#nullable restore
#line 14 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
                     if(@Model.CarrinhoCompraList.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"cart-table\">\n\t\t\t\t\t\t\t<h3>Itens Adicionados (");
#nullable restore
#line 16 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
                                              Write(Model.CarrinhoCompraList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</h3>
							<div class=""cart-table-warp"">
								<table>
								<thead>
									<tr>
										<th class=""product-th"">Produtos</th>
										<th class=""quy-th"">Quantidade</th>
										<th class=""size-th"">Tamanho</th>
										<th class=""total-th"">Preço</th>
										<th>Ação</th>
									</tr>
								</thead>
								<tbody>
");
#nullable restore
#line 29 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
                                     foreach (var item in Model.CarrinhoCompraList)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"product-col\">\n\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ddf34da20db10c90e576463182e2c0dc29e597796715", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 876, "~/arquivos/", 876, 11, true);
#nullable restore
#line 33 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
AddHtmlAttributeValue("", 887, item.Produto.Foto, 887, 18, false);

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
            WriteLiteral("\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"pc-title\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t<h4>");
#nullable restore
#line 35 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
                                                   Write(item.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\t\t\t\t\t\t\t\t\t\t\t\t\t<p>R$ ");
#nullable restore
#line 36 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
                                                     Write(item.Produto.Valor.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"quy-col\">\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"quantity\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 41 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
                                                  Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"size-col\"><h4>Size M</h4></td>\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"total-col\"><h4>R$ ");
#nullable restore
#line 45 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
                                                                    Write(item.Produto.Valor.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"total-col\">\n\t\t\t\t\t\t\t\t\t\t\t\t<button data-toggle=\"modal\" data-target=\"#modalDelete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1463, "\"", 1523, 3);
            WriteAttributeValue("", 1473, "abrirModalRemoveItem(this,", 1473, 26, true);
#nullable restore
#line 47 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
WriteAttributeValue(" ", 1499, item.CarrinhoCompraId, 1500, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1522, ")", 1522, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-carrinho-id=\"");
#nullable restore
#line 47 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
                                                                                                                                                                                 Write(item.CarrinhoCompraId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn text-danger abrir-modal-delete\" title=\"Remover item\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-times-circle fa-2x\"></i>\n\t\t\t\t\t\t\t\t\t\t\t\t</button>\n\t\t\t\t\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t\t\t\t\t</tr>\n");
#nullable restore
#line 52 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
										
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</tbody>\n\t\t\t\t\t\t\t</table>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div class=\"total-cost\">\n\t\t\t\t\t\t\t\t<h6>Total <span>R$ ");
#nullable restore
#line 58 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
                                              Write(Model.ValorTotalItems.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n");
#nullable restore
#line 61 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
					}else {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<h1 class=\"text-center\">Você não tem nenhum Produto adicionado ao carrinho de compras.</h1>\n");
#nullable restore
#line 63 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<div class=\"col-lg-4 card-right\">\n\t\t\t\t\t<!---<form class=\"promo-code-form\">\n\t\t\t\t\t\t<input type=\"text\" placeholder=\"Enter promo code\">\n\t\t\t\t\t\t<button>Submit</button>\n\t\t\t\t\t</form>--->\n");
#nullable restore
#line 71 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
                     if(@Model.CarrinhoCompraList.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2314, "\"", 2321, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"site-btn\">continuar a compra</a>\n");
#nullable restore
#line 73 "/home/moobi/Divisima/Views/CarrinhoCompra/Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddf34da20db10c90e576463182e2c0dc29e5977912906", async() => {
                WriteLiteral("continue comprando");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
				</div>
			</div>
		</div>
	</section>
	<!-- cart section end -->

	<!-- Related product section -->
	<section class=""related-product-section"">
		<div class=""container"">
			<div class=""section-title text-uppercase"">
				<h2>Continuar comprando</h2>
			</div>
			<div class=""row"">
				<div class=""col-lg-3 col-sm-6"">
					<div class=""product-item"">
						<div class=""pi-pic"">
							<div class=""tag-new"">New</div>
							<img src=""./img/product/2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2923, "\"", 2929, 0);
            EndWriteAttribute();
            WriteLiteral(@">
							<div class=""pi-links"">
								<a href=""#"" class=""add-card""><i class=""flaticon-bag""></i><span>ADD TO CART</span></a>
								<a href=""#"" class=""wishlist-btn""><i class=""flaticon-heart""></i></a>
							</div>
						</div>
						<div class=""pi-text"">
							<h6>$35,00</h6>
							<p>Black and White Stripes Dress</p>
						</div>
					</div>
				</div>
				<div class=""col-lg-3 col-sm-6"">
					<div class=""product-item"">
						<div class=""pi-pic"">
							<img src=""./img/product/5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3422, "\"", 3428, 0);
            EndWriteAttribute();
            WriteLiteral(@">
							<div class=""pi-links"">
								<a href=""#"" class=""add-card""><i class=""flaticon-bag""></i><span>ADD TO CART</span></a>
								<a href=""#"" class=""wishlist-btn""><i class=""flaticon-heart""></i></a>
							</div>
						</div>
						<div class=""pi-text"">
							<h6>$35,00</h6>
							<p>Flamboyant Pink Top </p>
						</div>
					</div>
				</div>
				<div class=""col-lg-3 col-sm-6"">
					<div class=""product-item"">
						<div class=""pi-pic"">
							<img src=""./img/product/9.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3912, "\"", 3918, 0);
            EndWriteAttribute();
            WriteLiteral(@">
							<div class=""pi-links"">
								<a href=""#"" class=""add-card""><i class=""flaticon-bag""></i><span>ADD TO CART</span></a>
								<a href=""#"" class=""wishlist-btn""><i class=""flaticon-heart""></i></a>
							</div>
						</div>
						<div class=""pi-text"">
							<h6>$35,00</h6>
							<p>Flamboyant Pink Top </p>
						</div>
					</div>
				</div>
				<div class=""col-lg-3 col-sm-6"">
					<div class=""product-item"">
						<div class=""pi-pic"">
							<img src=""./img/product/1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4402, "\"", 4408, 0);
            EndWriteAttribute();
            WriteLiteral(@">
							<div class=""pi-links"">
								<a href=""#"" class=""add-card""><i class=""flaticon-bag""></i><span>ADD TO CART</span></a>
								<a href=""#"" class=""wishlist-btn""><i class=""flaticon-heart""></i></a>
							</div>
						</div>
						<div class=""pi-text"">
							<h6>$35,00</h6>
							<p>Flamboyant Pink Top </p>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!-- Related product section end -->

	<!-- Modal delete-->
	<div class=""modal fade"" id=""modalDelete"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
		<div class=""modal-dialog modal-md"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h5 class=""modal-title"" id=""exampleModalLabel"">Tem certeza que deseja Deletar este produto?</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
					<span aria-hidden=""true"">&times;</span>
					</button>
					");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddf34da20db10c90e576463182e2c0dc29e5977917872", async() => {
                WriteLiteral("\n\t\t\t\t\t\t<input type=\"hidden\" name=\"carrinho-id\" class=\"carrinho-id\">\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
					<button type=""button"" class=""btn-estilizado btn-cinza"" data-dismiss=""modal"">Fechar</button>
					<button type=""button"" class=""btn-estilizado btn-roza"" onclick=""removerItem()"">Deletar</button>
				</div>
			</div>
		</div>
	</div>
	<!-- Fim Modal delete -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarrinhoCompraViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
