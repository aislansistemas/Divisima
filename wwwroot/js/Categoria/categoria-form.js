

$('#btn-cad-categoria').on('click', () => {
    let inpNome = $('.nome-categoria').val();
    if(inpNome.length == 0){
        $('.validate-nome').text("Nome da categoria deve ser preenchido");
    } else {
        cadastrarCategoriaAjax(inpNome)
    }
 
})

$('#btn-edit-categoria').on('click', () => {
    let inpId = $('.id-categoria').val();
    let inpNome = $('.nome-categoria').val();
    if(inpNome.length == 0){
        $('.validate-nome').text("Nome da categoria deve ser preenchido");
    } else {
        editarCategorias(inpId, inpNome);
    }
})

$('#btn-inat-categoria').on('click', () => {
    let inpId = $('.id-categoria').val();
    if(inpId.length == 0){
        toastr.warning("Categoria não encontrada",{
            iconClass:'toast-warning',
            timeOut: 5000,
        });
    } else {
        inativarCategoria(inpId);
    }
})

$('#btn-ativ-categoria').on('click', () => {
    let inpId = $('.id-categoria').val();
    if(inpId.length == 0){
        toastr.warning("Categoria não encontrada",{
            iconClass:'toast-warning',
            timeOut: 5000,
        });
    } else {
        ativarCategoria(inpId);
    }
})
