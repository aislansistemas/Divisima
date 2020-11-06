var inputCarrinhoId = $('.carrinho-id');

function abrirModalRemoveItem(e, carrinhoId){
    inputCarrinhoId.val(carrinhoId);
}

function removerItem(){
    let carrinhoId = inputCarrinhoId.val();
    $.post('/CarrinhoCompra/Remover', {carrinhoId} ,(response) => {
        console.log(response);
    });
}