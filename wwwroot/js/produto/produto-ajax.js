
$(getProducts);

var numberPage = 1;
var limit = 5;

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
        imgLoading.remove();
        adicionaExibicaoProdutos(dados.produtos);
    })
}

function setGifLoading(){
    var posicaoLoading = $(".row-all-products").offset().top;
    $("body").animate(
    {
        scrollTop: posicaoLoading + "px"
    }, 1000);

    let imgLoading = $('<img>')
    .attr('src', 'img/carregamento.gif')
    imgLoading.slideDown(100);
    //.addClass('rounded mx-auto d-block col-md-offset-3');
    $('.row-all-products').prepend(imgLoading);
    return imgLoading;
}