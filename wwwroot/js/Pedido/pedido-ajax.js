$(carregarCarrinhoIntensResumo());

function carregarCarrinhoIntensResumo() {
    $.get("/Pedido/ItensCarrinhoResumo", (response) => {
        console.log(response);
        montarHtmlCarrinhoItens(response)
    });
}

function montarHtmlCarrinhoItens(response) {
    $('.total-itens-carrinho').text('Intens no carrinho (' + response.carrinhoCompraList.length + ')');
    $('.valor-total-itens').text( getValorFormatado(response.valorTotalItems) );

    let carrinhoCompraList = response.carrinhoCompraList;
    carrinhoCompraList.forEach(item => {

        let divConteinerImagem = $('<div>').addClass('pl-thumb');
        let fotoProduto = $('<img>').attr('src', '/arquivos/' + item.produto.foto).attr('id', 'img-item-carrinho-compras');
        divConteinerImagem.append(fotoProduto);

        let nomeProduto = $('<h6>').text(item.produto.nome);
        let valorFormatado = getValorFormatado(item.produto.valor);
        let valorProduto = $('<p>').text(valorFormatado);
        let li = $('<li>');

        li.append(divConteinerImagem);
        li.append(nomeProduto);
        li.append(valorProduto);
        $('.product-list').append(li);

    });
}

function getValorFormatado(valor){
    let valorFormatado = valor.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
    return valorFormatado; 
}