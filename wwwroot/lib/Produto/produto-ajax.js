$(getProdutos());

function getProdutos(){
    $.get('/Admin/Produto/GetProdutos', (dados) => {
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
            }
            procedimentoPadrao(response);
        },
        error: function(XMLHttpRequest, textStatus, errorThrown){
            console.log(XMLHttpRequest);
        }
    });
}

function deletarProduto(){
    data = {id : $('.id-produto').val()}
    $.post('/Admin/Produto/Deletar', data, (response) => {
        procedimentoPadrao(response);
    })
}

function procedimentoPadrao(dados) {
    $('#tabela-list-produto').text('');
    montaTabelaProduto(dados.produtos);
    montaSelectCategorias(dados.categoriasAtivas);
}