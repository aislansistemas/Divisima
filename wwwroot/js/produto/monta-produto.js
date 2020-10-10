function adicionaExibicaoProdutos(dados){
    for(let i = 0; i < dados.length; i++){
        let produto = dados[i];
        ///div//////
        let divCol3 = $('<div>').addClass('col-md-3');
        let divProductItem = $('<div>').addClass('product-item');
        let divPiPic = $('<div>').addClass('pi-pic');
        let divPiLinks = $('<div>').addClass('pi-links');
        let divPiText = $('<div>').addClass('pi-text');
        ///div/////
        let img = $('<img>').attr('src', '../arquivos/' + produto.foto).addClass('img-list-products');
        //////////////////////////////////////
        let iconeAddCart = $('<i>').addClass('flaticon-bag');
        let spanTextAddCart = $('<span>').text('Adicionar');
        let linkAddCart = $('<a>').addClass('add-card');
        linkAddCart.append(iconeAddCart);
        linkAddCart.append(spanTextAddCart);
        /////////////////////////////////////
        let iconeDetalhes = $('<i>').addClass('fa fa-eye icone-ver-detalhes');
        let linkDetails = getLinkDetails(produto.produtoId);
        linkDetails.append(iconeDetalhes);
        /////////////////////////////////////////
        let valorFormatado = getValorFormatado(produto.valor);
        let h6Valor = $('<h6>').text(valorFormatado);
        let pNomeProduto = $('<p>').text(produto.nome);
        //////apends divptext/////
        divPiText.append(h6Valor);
        divPiText.append(pNomeProduto);
        /////////////////////
        ///apends divpilinks ////
        divPiLinks.append(linkAddCart);
        divPiLinks.append(linkDetails);
        ////////////////////////
        ////apends pi-pic /////
        divPiPic.append(img);
        divPiPic.append(divPiLinks);
        //////////////////////
        ////apends productitem////
        divProductItem.append(divPiPic);
        divProductItem.append(divPiText);
        //////////////
        ////apends - div col3///
        divCol3.append(divProductItem);
        ///////////
        $('.row-all-products').append(divCol3);
    }
}

function getLinkDetails(id){
    let linkDetails = $('<a>')
    .addClass('wishlist-btn')
    .attr('title', 'Ver Detalhes do Produto')
    .attr('data-id', id)
    .on('click', getProdutoById);

    return linkDetails;
}

function getValorFormatado(valor){
    let valorFormatado = valor.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
    return valorFormatado; 
}