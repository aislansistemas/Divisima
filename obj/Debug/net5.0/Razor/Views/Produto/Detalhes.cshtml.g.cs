#pragma checksum "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "713e1d521ae86bbd828d560e44e463343b050285"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Detalhes), @"mvc.1.0.view", @"/Views/Produto/Detalhes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"713e1d521ae86bbd828d560e44e463343b050285", @"/Views/Produto/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81329903b06ff0ef882dbb34bb0d186757576cd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-big-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("prod-id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Ver Detalhes do Produto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
	<!-- Page info -->
	<div class=""page-top-info"">
		<div class=""container"">
		</div>
	</div>
	<!-- Page info end -->

	<!-- product section -->
	<section class=""product-section"">
		<div class=""container"">
			<div class=""container d-flex justify-content-center"">
			<div class=""alert alert-secondary feed-quantidade-invalida"" role=""alert"">
				<i class=""fa fa-exclamation-circle fa-2x text-danger""></i> 
  				<strong class=""text-danger pr-2 mensage-invalid-quantidade""></strong>
				<button type=""button"" class=""close btn-close-feed-invalid"" aria-label=""Close"">
    				<span aria-hidden=""true"">&times;</span>
  				</button>
			</div>
		</div>
			<div class=""row"">
				<div class=""col-lg-6"">
					<div class=""product-pic-zoom"">
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "713e1d521ae86bbd828d560e44e463343b0502856262", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 817, "~/", 817, 2, true);
#nullable restore
#line 25 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
AddHtmlAttributeValue("", 819, Functions.GetPathUploadProdutos(), 819, 34, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 853, "/", 853, 1, true);
#nullable restore
#line 25 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
AddHtmlAttributeValue("", 854, Model.Produto.Foto[0].Foto, 854, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"product-thumbs\" tabindex=\"1\" style=\"overflow: hidden; outline: none;\">\r\n\t\t\t\t\t\t<div class=\"product-thumbs-track\">\r\n");
#nullable restore
#line 29 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                             foreach (var fotos in @Model.Produto.Foto)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"pt active fotos-produtos-list\" data-imgbigurl=\"/");
#nullable restore
#line 31 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                                                                                       Write(Functions.GetPathUploadProdutos());

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 31 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                                                                                                                          Write(fotos.Foto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "713e1d521ae86bbd828d560e44e463343b0502859287", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1235, "~/", 1235, 2, true);
#nullable restore
#line 32 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
AddHtmlAttributeValue("", 1237, Functions.GetPathUploadProdutos(), 1237, 34, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1271, "/", 1271, 1, true);
#nullable restore
#line 32 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
AddHtmlAttributeValue("", 1272, fotos.Foto, 1272, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 34 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-lg-6 product-details\">\r\n\t\t\t\t\t<h2 class=\"p-title\">");
#nullable restore
#line 39 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                                   Write(Model.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\t\t\t\t\t<h3 class=\"p-price\">R$ ");
#nullable restore
#line 40 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                                      Write(Model.Produto.Valor.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
					<h4 class=""p-stock"">Disponível: <span>Em estoque</span></h4>
					<!------------------ implementação futura
					<div class=""p-rating"">
						<i class=""fa fa-star-o""></i>
						<i class=""fa fa-star-o""></i>
						<i class=""fa fa-star-o""></i>
						<i class=""fa fa-star-o""></i>
						<i class=""fa fa-star-o fa-fade""></i>
					</div>
					
					<div class=""p-review"">
						<a href="""">3 reviews</a>|<a href="""">Add your review</a>
					</div>
					<div class=""fw-size-choose"">
						<p>Size</p>
						<div class=""sc-item"">
							<input type=""radio"" name=""sc"" id=""xs-size"">
							<label for=""xs-size"">32</label>
						</div>
						<div class=""sc-item"">
							<input type=""radio"" name=""sc"" id=""s-size"">
							<label for=""s-size"">34</label>
						</div>
						<div class=""sc-item"">
							<input type=""radio"" name=""sc"" id=""m-size"" checked="""">
							<label for=""m-size"">36</label>
						</div>
						<div class=""sc-item"">
							<input type=""radio"" name=""sc"" id=""l-size"">
							<label ");
            WriteLiteral(@"for=""l-size"">38</label>
						</div>
						<div class=""sc-item disable"">
							<input type=""radio"" name=""sc"" id=""xl-size"" disabled>
							<label for=""xl-size"">40</label>
						</div>
						<div class=""sc-item"">
							<input type=""radio"" name=""sc"" id=""xxl-size"">
							<label for=""xxl-size"">42</label>
						</div>
					</div> ----->
					<div class=""quantity"">
						<p>Quantidade</p>
						<div class=""col-md-3"">
                        	<div class=""pro-qty""><input class=""input-quantidade"" type=""text"" value=""1""></div>
						</div>
						<div class=""col-md-3"">
							<small class=""xl-size disable text-secondary p-stock quantidade-value"" data-item-disponivel=""");
#nullable restore
#line 87 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                                                                                                                    Write(Model.Produto.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 87 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                                                                                                                                               Write(Model.Produto.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" items disponíveis</small>\r\n\t\t\t\t\t\t</div>\r\n                    </div>\r\n\t\t\t\t\t<!---- implementação futura \r\n\t\t\t\t\t<a href=\"#\" class=\"site-btn\">COMPRAR</a> ------>\r\n\t\t\t\t\t<input type=\"hidden\" id=\"input-usuario-logado\"");
            BeginWriteAttribute("value", " value=\"", 3488, "\"", 3515, 1);
#nullable restore
#line 92 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
WriteAttributeValue("", 3496, User.Identity.Name, 3496, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t<button data-id=\"");
#nullable restore
#line 93 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                                Write(Model.Produto.ProdutoId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""site-btn btn-primary add-cart"">Adicionar ao carrinho</button>
					<div id=""accordion"" class=""accordion-area"">
						<div class=""panel"">
							<div class=""panel-header"" id=""headingOne"">
								<button class=""panel-link active"" data-toggle=""collapse"" data-target=""#collapse1"" aria-expanded=""true"" aria-controls=""collapse1"">Detalhes</button>
							</div>
							<div id=""collapse1"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordion"">
								<div class=""panel-body"">
									<p>");
#nullable restore
#line 101 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                                  Write(Model.Produto.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
								</div>
							</div>
						</div>
						<!---- implementação futura
						<div class=""panel"">
							<div class=""panel-header"" id=""headingTwo"">
								<button class=""panel-link"" data-toggle=""collapse"" data-target=""#collapse2"" aria-expanded=""false"" aria-controls=""collapse2"">care details </button>
							</div>
							<div id=""collapse2"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
								<div class=""panel-body"">
									<img src=""./img/cards.png"" alt="""">
									<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin pharetra tempor so dales. Phasellus sagittis auctor gravida. Integer bibendum sodales arcu id te mpus. Ut consectetur lacus leo, non scelerisque nulla euismod nec.</p>
								</div>
							</div>
						</div>
						<div class=""panel"">
							<div class=""panel-header"" id=""headingThree"">
								<button class=""panel-link"" data-toggle=""collapse"" data-target=""#collapse3"" aria-expanded=""false"" aria-controls=""collapse3"">shipping & ");
            WriteLiteral(@"Returns</button>
							</div>
							<div id=""collapse3"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordion"">
								<div class=""panel-body"">
									<h4>7 Days Returns</h4>
									<p>Cash on Delivery Available<br>Home Delivery <span>3 - 4 days</span></p>
									<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin pharetra tempor so dales. Phasellus sagittis auctor gravida. Integer bibendum sodales arcu id te mpus. Ut consectetur lacus leo, non scelerisque nulla euismod nec.</p>
								</div>
							</div>
						</div>------------------->
					</div>
				<!--------------redes sociais----------------------->
					<!------ implementação futura
					<div class=""social-sharing"">
						<a href=""""><i class=""fa fa-google-plus""></i></a>
						<a href=""""><i class=""fa fa-pinterest""></i></a>
						<a href=""""><i class=""fa fa-facebook""></i></a>
						<a href=""""><i class=""fa fa-twitter""></i></a>
						<a href=""""><i class=""fa fa-youtube""></i></a>
					</div> -----");
            WriteLiteral(@"------------------->
				<!--------------redes sociais----------------------->
				</div>
			</div>
		</div>
	</section>
	<!-- product section end -->

	<!-- RELATED PRODUCTS section -->
	<section class=""related-product-section"">
		<div class=""container"">
			<div class=""section-title"">
				<h2>Produtos Similares</h2>
			</div>
			<div class=""product-slider owl-carousel carousel-produtos-por-categoria"">
");
#nullable restore
#line 153 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                 foreach (var produto in @Model.Produtos)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"product-item\">\r\n\t\t\t\t\t\t<div class=\"pi-pic\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "713e1d521ae86bbd828d560e44e463343b05028519039", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6712, "~/", 6712, 2, true);
#nullable restore
#line 157 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
AddHtmlAttributeValue("", 6714, Functions.GetPathUploadProdutos(), 6714, 34, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6748, "/", 6748, 1, true);
#nullable restore
#line 157 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
AddHtmlAttributeValue("", 6749, produto.Foto[0].Foto, 6749, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"pi-links\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "713e1d521ae86bbd828d560e44e463343b05028520921", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<i class=\"fa fa-eye icone-ver-detalhes\"></i>\r\n\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 159 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                                                                           WriteLiteral(produto.ProdutoId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"pi-text\">\r\n\t\t\t\t\t\t\t<h6>R$");
#nullable restore
#line 165 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                             Write(produto.Valor.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\t\t\t\t\t\t\t<p>");
#nullable restore
#line 166 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
                          Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 169 "D:\projetos\Divisima\Views\Produto\Detalhes.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n\t<!-- RELATED PRODUCTS section end -->");
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
