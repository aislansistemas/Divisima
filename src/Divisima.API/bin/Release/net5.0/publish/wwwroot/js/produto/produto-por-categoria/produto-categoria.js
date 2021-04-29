$(getProductsPorCategoria);

var inputCategoriaId = $('#input-categoria-id').val();
var numberPage = 1;
var limit = 4;

function getProductsPorCategoria(){

    $.get('/Produto/ProdutosPorCategoriaAjax/' + inputCategoriaId, {numberPage, limit}, (dados) => {
        adicionaExibicaoProdutosPorCategoria(dados.produtos);
    })
}

function carregarMaisProdutosPorCategoria(){
    numberPage++;
    let imgLoading = setGifLoading();
    $.get('/Produto/ProdutosPorCategoriaAjax/' + inputCategoriaId, {numberPage, limit}, (dados) => {
        setTimeout(() => {
            imgLoading.remove();
            $(".btn-close-modal").click();
            adicionaExibicaoProdutos(dados.produtos);
        }, 1200);
    })
    
}

function setGifLoading(){
    let imgLoading = $('<img>').attr('src', '../../img/carregamento.gif');
    $('.modal-content').prepend(imgLoading);
    return imgLoading;
}
