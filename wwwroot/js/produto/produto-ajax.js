
$(getProducts);

var numberPage = 1;
var limit = 4;

function getProducts(){

    $.get('/Produto/ListProductsJson', {numberPage, limit}, (dados) => {
        console.log(dados);
        adicionaExibicaoProdutos(dados.produtos)
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
    numberPage++;
    let imgLoading = setGifLoading();
    $.get('/Produto/ListProductsJson', {numberPage, limit}, (dados) => {
        setTimeout(() => {
            imgLoading.remove();
            $(".btn-close-modal").click();
            adicionaExibicaoProdutos(dados.produtos);
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

function adicionarItemAoCarrinho(produtoId, quantidade){
    $.post('/CarrinhoCompra/Adicionar', {produtoId, quantidade}, (response) => {
        alert('sucesso');
    })
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

    return true;
}