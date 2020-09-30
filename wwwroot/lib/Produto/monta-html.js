function montaTabelaProduto(dados){
    for(let i = 0; i < dados.length; i++){
        
        let produtos = dados[i];
        let tr = setElement('tr', 'tr-produtos');
        let tdNome = setElement('td', 'td-nome', produtos.nome);
        let tdQuantidade = setElement('td', 'td-quantidade', produtos.quantidade);
        let valorFormatado = getValorFormatado(produtos.valor);
        let tdValor = setElement('td', 'td-valor', valorFormatado);
        let tdBtnDetalhe = setElement('td', 'td-btn-detalhe');
        let BtnDetalhes = getElementButtonProducts('detalhe', produtos.produtoId, produtos.foto,produtos.nome, produtos.descricao, produtos.quantidade, valorFormatado, produtos.tamanho, produtos.categoria.nome);
        tdBtnDetalhe.append(BtnDetalhes);
        tr.append(tdNome);
        tr.append(tdQuantidade);
        tr.append(tdValor);
        tr.append(tdBtnDetalhe);
        $('#tabela-list-produto').append(tr);

    }
}

function getElementButtonProducts(
    acao, 
    id, 
    foto = null, 
    nome = null, 
    descricao = null, 
    quantidade = null, 
    valor = null, 
    tamanho = null, 
    categoria = null
){
    btn = $('<button>');
    switch(acao){
        case "detalhe" :
            return btn.attr('data-id', id)
            .attr('data-toggle', 'modal')
            .attr('data-target', '#modal-detalhe-produto')
            .addClass('btn btn-warning btn-sm btn-detalhe')
            .text('Detalhes')
            .on('click', () => {   
                setTextForDatailsProducts(foto, nome, descricao, quantidade, valor, tamanho, categoria);
            });
        case "edit" :
            return btn.attr('data-id', id)
            .attr('data-toggle', 'modal')
            .attr('data-target', '#EditModal')
            .addClass('btn btn-primary btn-sm btn-edit')
            .text('Editar')
            .on('click', () => {   
                console.log('aaa');
            });
        case "delete" :
            return btn.attr('data-id', id)
            .attr('data-toggle', 'modal')
            .attr('data-target', '#DeleteModal')
            .addClass('btn btn-danger btn-sm btn-delete')
            .text('Deletar')
            .on('click', () => {   
                console.log('aaa');
            });        
    }
}

function setElement(element, className, text = null){
    return $('<' + element + '>').addClass(className).text(text);
}

function montaSelectCategorias(dados){
    for(let i = 0; i < dados.length; i++){
        let categoriaList = dados[i];
        let options = $('<option>').addClass('text-dark').val(categoriaList.categoriaId).text(categoriaList.nome);
        $('#select-categorias').append(options);
    }
}

function setTextForDatailsProducts(
    foto = null, 
    nome = null, 
    descricao = null, 
    quantidade = null, 
    valor = null, 
    tamanho = null, 
    categoria = null
){
    let tamanhoFormatado = getTamanhoFormatado(tamanho);
    $('.foto-detalhe-produto').attr('src', '../arquivos/' + foto);
    $('.text-name-produto').text(nome);
    $('.text-descricao-produto').text(descricao);
    $('.text-quantidade-produto').text(quantidade);
    $('.text-valor-produto').text(valor);
    $('.text-tamanho-produto').text(tamanhoFormatado);
    $('.text-categoria-produto').text(categoria);
}


