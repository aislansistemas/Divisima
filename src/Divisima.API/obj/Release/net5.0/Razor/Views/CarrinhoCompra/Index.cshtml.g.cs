#pragma checksum "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4680107c0095b10848bcf82a9515b81d60ed085d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4680107c0095b10848bcf82a9515b81d60ed085d", @"/Views/CarrinhoCompra/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b8c7faf229841eb4f7e780745e9518078dfe9e", @"/Views/_ViewImports.cshtml")]
    public class Views_CarrinhoCompra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarrinhoCompraViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("site-btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckoutMercadoPago", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("site-btn sb-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-remove-carrinho-id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\t<!-- Page info -->\r\n\t<div class=\"page-top-info\">\r\n\t\t\r\n\t</div>\r\n\t<!-- Page info end -->\r\n\r\n\t<!-- cart section end -->\r\n\t<section class=\"cart-section spad\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-lg-8\">\r\n\r\n");
#nullable restore
#line 14 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
                     if(@Model.CarrinhoCompraList.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"cart-table\">\r\n\t\t\t\t\t\t\t<h3>Itens Adicionados (");
#nullable restore
#line 16 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
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
										<!----<th class=""size-th"">Tamanho</th>----->
										<th class=""total-th"">Preço</th>
										<th>Ação</th>
									</tr>
								</thead>
								<tbody>
");
#nullable restore
#line 29 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
                                     foreach (var item in Model.CarrinhoCompraList)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"product-col\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4680107c0095b10848bcf82a9515b81d60ed085d8501", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 920, "~/arquivos/", 920, 11, true);
#nullable restore
#line 33 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
AddHtmlAttributeValue("", 931, item.Produto.Foto[0].Foto, 931, 26, false);

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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"pc-title\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<h4>");
#nullable restore
#line 35 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
                                                   Write(item.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 36 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
                                                  Write(item.Produto.Valor.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"quy-col\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"quantity\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 41 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
                                                  Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<!---<td class=\"size-col\"><h4>Size M</h4></td>--->\r\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"total-col\"><h4>");
#nullable restore
#line 45 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
                                                                 Write(item.Produto.Valor.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td class=\"total-col\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<button data-toggle=\"modal\" data-target=\"#modalDelete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1532, "\"", 1592, 3);
            WriteAttributeValue("", 1542, "abrirModalRemoveItem(this,", 1542, 26, true);
#nullable restore
#line 47 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue(" ", 1568, item.CarrinhoCompraId, 1569, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1591, ")", 1591, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-carrinho-id=\"");
#nullable restore
#line 47 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
                                                                                                                                                                                 Write(item.CarrinhoCompraId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn text-danger abrir-modal-delete\" title=\"Remover item\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-times-circle fa-2x\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 52 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
										
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"total-cost\">\r\n\t\t\t\t\t\t\t\t<h6>Total <span>");
#nullable restore
#line 58 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
                                           Write(Model.ValorTotalItems.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 61 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
					}else {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<h1 class=\"text-center\">Você não tem nenhum Produto adicionado ao carrinho de compras.</h1>\r\n");
#nullable restore
#line 63 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-lg-4 card-right\">\r\n\t\t\t\t\t<!---<form class=\"promo-code-form\">\r\n\t\t\t\t\t\t<input type=\"text\" placeholder=\"Enter promo code\">\r\n\t\t\t\t\t\t<button>Submit</button>\r\n\t\t\t\t\t</form>--->\r\n");
#nullable restore
#line 71 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
                     if(@Model.CarrinhoCompraList.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<!---<a asp-action=\"Checkout\" asp-controller=\"Pedido\" class=\"site-btn\">continuar a compra</a>--->\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4680107c0095b10848bcf82a9515b81d60ed085d14839", async() => {
                WriteLiteral("continuar a compra");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
                                                                                                                   WriteLiteral(Model.CarrinhoCompraList[0].ProdutoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 74 "D:\projetos\Divisima\src\Divisima.API\Views\CarrinhoCompra\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4680107c0095b10848bcf82a9515b81d60ed085d17590", async() => {
                WriteLiteral("continue comprando");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
	<!---- implementação futura 
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
							<img src=""./img/product/2.jpg"" alt="""">
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
			</div>
		</div>
	</section>------------------------>
	<!-- Related product section end -->

	<!-- Modal delete-->
	<div class=""modal ");
            WriteLiteral(@"fade"" id=""modalDelete"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
		<div class=""modal-dialog modal-md"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">
					<h5 class=""modal-title"" id=""exampleModalLabel"">Tem certeza que deseja remover este produto?</h5>
					<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
					<span aria-hidden=""true"">&times;</span>
					</button>
					");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4680107c0095b10848bcf82a9515b81d60ed085d20651", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<input type=\"hidden\" name=\"carrinho-id\" class=\"carrinho-id\">\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
