var divFeedQuantidade = $('.feed-quantidade-invalida');

$(divFeedQuantidade.hide());

function getValorFormatado(valor){
    let valorFormatado = valor.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
    return valorFormatado; 
}

function exibirFeedValidacaoQuantidade(mensagem){
    $('.mensage-invalid-quantidade').text(mensagem);
    divFeedQuantidade.show();
}

$('.btn-close-feed-invalid').on('click', (e) => {
    e.preventDefault();
    divFeedQuantidade.hide();
});
