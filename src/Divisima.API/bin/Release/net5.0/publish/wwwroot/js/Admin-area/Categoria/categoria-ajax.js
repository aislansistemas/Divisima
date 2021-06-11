
$(getCategorias());

function cadastrarCategoriaAjax(nome){
    let data = {nome : nome};
    $.post("/Admin/Categoria/Cadastrar", data, (response) => {
        $('.close-modal-cadastrar').click();
        procedimentoPadraoCategoria(response.mensagem, response.categorias)
    })
    .fail();
}

function getCategorias(){
    $.get("/Admin/Categoria/GetAllJson", (dados) => {
        montaTabelaCategoria(dados);
    })
    .fail().always();
}

function editarCategorias(id, nome){
    let data = {
        categoriaId: id,
        nome : nome
    };
    $.post("/Admin/Categoria/Editar", data, (response) => {
        $('.close-modal-editar').click();
        procedimentoPadraoCategoria(response.mensagem, response.categorias)
    })
    .fail().always();
}

function inativarCategoria(id){
    $.post("/Admin/Categoria/Inativar", {id}, (response) => {
        $('.close-modal-inativar').click();
        procedimentoPadraoCategoria(response.mensagem, response.categorias);
    })
    .fail().always();
}

function ativarCategoria(id){
    $.post("/Admin/Categoria/Ativar", {id}, (response) => {
        $('.close-modal-ativar').click();
        procedimentoPadraoCategoria(response.mensagem, response.categorias);
    })
    .fail().always();
}

function procedimentoPadraoCategoria(msg, categorias){
    toastr.success(msg,{
        iconClass:'toast-success',
        timeOut: 5000,
    });
    $('#tabela-list-categoria').text('');
    montaTabelaCategoria(categorias);
}

