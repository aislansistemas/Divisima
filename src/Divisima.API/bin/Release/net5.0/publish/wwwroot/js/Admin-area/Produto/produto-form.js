
function validateInputs(dados){
    $('.validate-nome').text(dados.erros.Nome.errors[0].errorMessage);
    $('.validate-valor').text(dados.erros.Valor.errors[0].errorMessage);
    $('.validate-quantidade').text(dados.erros.Quantidade.errors[0].errorMessage);
    $('.validate-tamanho').text(dados.erros.Tamanho.errors[0]?.errorMessage);
    $('.validate-foto').text(dados.erros.Foto.errors[0]?.errorMessage);
}