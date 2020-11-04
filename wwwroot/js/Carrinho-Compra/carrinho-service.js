$('.abrir-modal-delete').on('click', (e) => {
    e.preventDefault();
    let carrinhoId = $(this).next('input').val();
    console.log(carrinhoId)
    let inputCarrinhoId = $('.carrinho-id');
    inputCarrinhoId.val(carrinhoId);
});