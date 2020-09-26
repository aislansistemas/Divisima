function montaTabelaProduto(dados){
    for(let i = 0; i < dados.length; i++){

        let produtos = dados[i];
        let tr = $('<tr>').addClass('tr-produtos');
        let tdNome = setElement('td', 'td-nome', produtos.nome);
        let tdDescricao = setElement('td', 'td-descricao', produtos.descricao);
        let tdQuantidade = setElement('td', 'td-quantidade', produtos.quantidade);
        let valorFormatado = getValorFormatado(produtos.valor);
        let tdValor = setElement('td', 'td-valor', valorFormatado);
        let tamanhoFormatado = getTamanhoFormatado(produtos.tamanho);
        let tdTamanho = setElement('td', 'td-tamanho', tamanhoFormatado);
        let tdCategoria = setElement('td', 'td-categoria', produtos.categoria.nome);
        tr.append(tdNome);
        tr.append(tdDescricao);
        tr.append(tdQuantidade);
        tr.append(tdValor);
        tr.append(tdTamanho);
        tr.append(tdCategoria);
        $('#tabela-list-produto').append(tr);

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


