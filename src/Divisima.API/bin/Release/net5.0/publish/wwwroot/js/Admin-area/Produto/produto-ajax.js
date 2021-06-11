$(getProdutos());

var numberPage = 1;
var limit = 6;

function getProdutos(){
    numberPage = 1;
    limit = 6;
    $.get('/Admin/Produto/GetProdutos', {numberPage, limit}, (dados) => {
        montaTabelaProduto(dados.produtos);
        montaSelectCategorias(dados.categoriasAtivas);
        console.log(dados);
    })
}

function cadastrarProduto(){ 
    $.ajax({
        url: '/Admin/Produto/Cadastrar',
        method: 'post',
        data: new FormData($('#form-cadastro-produto')[0]),
        enctype: 'multipart/form-data',
        cache: false,
        contentType: false,
        processData: false,
        success: function(response){
            if(response.hasError){
                console.log(response);
                validateInputs(response);
            } else {
                $('.close-modal-cadastro').click();
                toastr.success(response.mensagem, {
                    iconClass:'toast-success',
                    timeOut: 5000,
                });
                procedimentoPadrao(response);
            }
        },
        error: function(XMLHttpRequest, textStatus, errorThrown){
            console.log(XMLHttpRequest);
        }
    });
}

function deletarProduto(){
    data = {id : $('.id-produto').val()}
    $.post('/Admin/Produto/Deletar', data, (response) => {
        $('.close-modal-delete').click();
        toastr.success(response.mensagem, {
            iconClass:'toast-success',
            timeOut: 5000,
        });
        procedimentoPadrao(response);
    })
}

function editarProduto(){
    $.ajax({
        url: '/Admin/Produto/Editar',
        method: 'post',
        data: new FormData($('#form-edit-produto')[0]),
        enctype: 'multipart/form-data',
        cache: false,
        contentType: false,
        processData: false,
        success: function(response){
            if(response.hasError){
                console.log(response);
                validateInputs(response);
            } else {
                toastr.success(response.mensagem, {
                    iconClass:'toast-success',
                    timeOut: 5000,
                });
                procedimentoPadrao(response);
            }
        },
        error: function(XMLHttpRequest, textStatus, errorThrown){
            console.log(XMLHttpRequest);
        }
    });
}

function procedimentoPadrao(dados) {
    $('#tabela-list-produto').text('');
    montaTabelaProduto(dados.produtos);
    montaSelectCategorias(dados.categoriasAtivas);
}

function carregaMaisProdutos(){
    numberPage++;
    $.get('/Admin/Produto/GetProdutos', {numberPage, limit}, (dados) => {
        montaTabelaProduto(dados.produtos);
        montaSelectCategorias(dados.categoriasAtivas);
    })
}