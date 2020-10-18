
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