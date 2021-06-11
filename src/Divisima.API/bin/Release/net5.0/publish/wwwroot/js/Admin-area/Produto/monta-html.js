function montaTabelaProduto(dados){
    for(let i = 0; i < dados.length; i++){
    
        let produtos = dados[i];
        let tr = setElement('tr', 'tr-produtos');
        let tdNome = setElement('td', 'td-nome', produtos.nome);
        let tdQuantidade = setElement('td', 'td-quantidade', produtos.quantidade);
        let valorFormatado = getValorFormatado(produtos.valor);
        let tdValor = setElement('td', 'td-valor', valorFormatado);
        let tdBtnDetalhe = setElement('td', 'td-btn-detalhe');
        let btnDetalhes = getElementButtonProducts('detalhe', produtos.produtoId, produtos.foto[0].foto, produtos.nome, produtos.descricao, produtos.quantidade, valorFormatado, produtos.tamanho, produtos.categoria.nome, produtos.linkMercadoPago);
        let tdBtnDelete = setElement('td', 'td-btn-delete');
        let btnDelete = getElementButtonProducts('delete', produtos.produtoId);
        //let tdBtnEdit = setElement('td', 'td-btn-edit');
        //let btnEdit = getElementButtonProducts('edit', produtos.produtoId, produtos.foto[0].foto,produtos.nome, produtos.descricao, produtos.quantidade, produtos.valor, produtos.tamanho, produtos.categoria);
        //tdBtnEdit.append(btnEdit);
        tdBtnDelete.append(btnDelete);
        tdBtnDetalhe.append(btnDetalhes);
        tr.append(tdNome);
        tr.append(tdQuantidade);
        tr.append(tdValor);
        tr.append(tdBtnDetalhe);
        tr.append(tdBtnDelete);
        //tr.append(tdBtnEdit);
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
    categoria = null,
    linkMercadoPago
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
                setTextForDatailsProducts(foto, nome, descricao, quantidade, valor, tamanho, categoria, linkMercadoPago);
            });
        case "edit" :
            return btn.attr('data-id', id)
            .attr('data-toggle', 'modal')
            .attr('data-target', '#modalEdit')
            .addClass('btn btn-primary btn-sm btn-edit')
            .text('Editar')
            .on('click', () => {   
                setValureForInputs(id, foto, nome, descricao, quantidade, valor, tamanho, categoria);
            });
        case "delete" :
            return btn.attr('data-id', id)
            .attr('data-toggle', 'modal')
            .attr('data-target', '#modalDelete')
            .addClass('btn btn-danger btn-sm btn-delete')
            .text('Deletar')
            .on('click', () => {   
                $('.id-produto').val(id);
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
        $('.categoria-produto').append(options);
    }
}

function setTextForDatailsProducts(
    foto = null, 
    nome = null, 
    descricao = null, 
    quantidade = null, 
    valor = null, 
    tamanho = null, 
    categoria = null,
    linkMercadoPago = null
){
    let tamanhoFormatado = getTamanhoFormatado(tamanho);
    $('.foto-detalhe-produto').attr('src', '../arquivos/' + foto);
    $('.text-name-produto').text(nome);
    $('.text-descricao-produto').text(descricao);
    $('.text-quantidade-produto').text(quantidade);
    $('.text-valor-produto').text(valor);
    $('.text-tamanho-produto').text(tamanhoFormatado);
    $('.text-categoria-produto').text(categoria);
    $('.text-link-mercado-pago-produto').attr('href', linkMercadoPago).text(linkMercadoPago);
}

function setValureForInputs(
    id,
    foto = null, 
    nome = null, 
    descricao = null, 
    quantidade = null, 
    valor = null, 
    tamanho = null, 
    categoria = null
){
    let tamanhoFormatado = getTamanhoFormatado(tamanho);
    $('.id-produto').val(id);
    $('.nome-produto').val(nome);
    $('.descricao-produto').val(descricao);
    $('.quantidade-produto').val(quantidade);
    $('.valor-produto').val(valor);
    let optionTamanho = $('<option>').val(tamanho).text(tamanhoFormatado).attr('selected', true);
    $('.tamanho-produto').append(optionTamanho);
    let optionCategoria = $('<option>').val(categoria.categoriaId).text(categoria.nome).attr('selected', true);
    $('.categoria-produto').append(optionCategoria);
    $('.foto-produto').attr('filename',foto);
    console.log(foto);
}

$('#btn-adicionar-inputs-foto').on('click', (e) => {
    e.preventDefault();
    //var divClone = $('#div-campos-foto-clone').removeClass('col-md-3');
    var divClonada = $('#div-campos-foto-clone').clone();
    $('#fotos-incluidas-input').prepend(divClonada);
});



