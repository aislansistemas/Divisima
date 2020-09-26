$(getProdutos());

function getProdutos(){
    $.get('/Admin/Produto/GetProdutos', (dados) => {
        montaTabelaProduto(dados.produtos);
        montaSelectCategorias(dados.categoriasAtivas);
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
            console.log(response);
        },
    });
}