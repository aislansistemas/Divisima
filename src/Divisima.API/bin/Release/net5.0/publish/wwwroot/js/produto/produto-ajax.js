
$(getProducts);

var numberPage = 1;
var limit = 4;

function getProducts(){

    $.get('/Produto/ListProductsAjax', {numberPage, limit}, (dados) => {
        $('.row-all-products').html(dados);
        getTituloPagina(dados.produtos);
    })
}

function getProdutoById(){
    let id = $(this).attr('data-id');
    $.get(`/Produto/Detalhes/${id}`, (response) => {
        if(response != "Produto não encontrado"){
            window.location.href = `/Produto/Detalhes/${id}`;
        }
    })
}

function carregaMaisProdutos(){
    limit += limit;
    let imgLoading = setGifLoading();
    $.get('/Produto/ListProductsAjax', {numberPage, limit}, (dados) => {
        setTimeout(() => {
            imgLoading.remove();
            $(".btn-close-modal").click();
            $(".row-all-products").html(dados);
        }, 1200);
    })
    
}

function setGifLoading(){
    let imgLoading = $('<img>').attr('src', 'img/carregamento.gif');
    $('.modal-content').prepend(imgLoading);
    return imgLoading;
}

$('.add-cart').on('click', (e) => {
    e.preventDefault();
    let produtoId = $('.add-cart').data('id');
    let quantidade = $('.input-quantidade').val();
    let result = validarInputQuantidade(quantidade);
    if(result){
        adicionarItemAoCarrinho(produtoId, quantidade);
    }
});

function adicionarItemAoCarrinho(produtoId, quantidade = 1){
    $.post('/CarrinhoCompra/Adicionar', {produtoId, quantidade}, (response) => {
        validaResponseAjax(response);
    })
}

function validaResponseAjax(response){
    if(response.status == "success"){
        $.toaster({ title : 'Sucesso', priority : response.status, message : response.mensagem });
        setTimeout(() => {
            window.location.href = "/CarrinhoCompra/";
        },800);
    } else {
        $.toaster({ title : 'Atenção', priority : response.status, message : response.mensagem });
    }
}

function validarInputQuantidade(quantidade){
    let quantidadeDisponivel = $('.quantidade-value').data('item-disponivel');
    if(quantidade < 1) {
        exibirFeedValidacaoQuantidade("Por favor informe a quantidade de produtos!");
        return false;
    }

    if(quantidade > quantidadeDisponivel){
        exibirFeedValidacaoQuantidade("Desculpe não temos essa quantidade em estoque!");
        return false;
    }

    let inputUsuario = $('#input-usuario-logado').val();
    console.log(inputUsuario);
    if(inputUsuario == null || inputUsuario == "" || inputUsuario == undefined) {
        exibirFeedValidacaoQuantidade("Por favor, faça login para poder adicionar o produto ao carrinho!");
        return false;
    }

    return true;
}