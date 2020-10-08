
$(getCategorias());

function cadastrarCategoriaAjax(nome){
    let data = {nome : nome};
    $.post("/Admin/Categoria/Cadastrar", data, (response) => {

        procedimentoPadrao(response.mensagem, response.categorias)
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
        procedimentoPadrao(response.mensagem, response.categorias)
    })
    .fail().always();
}

function inativarCategoria(id){
    $.post("/Admin/Categoria/Inativar", {id}, (response) => {

        procedimentoPadrao(response.mensagem, response.categorias);
    })
    .fail().always();
}

function ativarCategoria(id){
    $.post("/Admin/Categoria/Ativar", {id}, (response) => {

        procedimentoPadrao(response.mensagem, response.categorias);
    })
    .fail().always();
}

function procedimentoPadrao(msg, categorias){
    toastr.success(msg,{
        iconClass:'toast-success',
        timeOut: 5000,
    });
    $('#tabela-list-categoria').text('');
    montaTabelaCategoria(categorias);
}

