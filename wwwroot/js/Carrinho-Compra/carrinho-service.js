var inputCarrinhoId = $('.carrinho-id');

function abrirModalRemoveItem(e, carrinhoId){
    inputCarrinhoId.val(carrinhoId);
}

function removerItem(){
    let carrinhoId = inputCarrinhoId.val();
    $.post('/CarrinhoCompra/Remover', {carrinhoId} ,(response) => {
        validaResponseAjax(response);
    });
}

function validaResponseAjax(response){
    if(response.status == "success"){
        $.toaster({ title : 'Sucesso', priority : response.status, message : response.mensagem });
        setTimeout(() => {
            window.location.href = "/CarrinhoCompra";
        },800);
    } else {
        $.toaster({ title : 'Atenção', priority : response.status, message : response.mensagem });
    }
}