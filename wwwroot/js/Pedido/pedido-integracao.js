
$('#consultar-cep').on('blur', () => {
    $.get("https://viacep.com.br/ws/" + $('#consultar-cep').val() + "/json/", (response) => {
        if(!response.erro) {
            $('#cidade').val(response.localidade);
            $('#estado').val(response.uf);
            exibirFeedCepInvalido(false);
        } else {
            $('#cidade').val('');
            $('#estado').val('');
            exibirFeedCepInvalido(true);
        }
    });
});

function exibirFeedCepInvalido(exibir){
    let iconWarning = $('<i>').addClass('fa fa-exclamation-circle text-danger');
    if(exibir){
        $('#feed-valida-cep').text(' Ops ! O Cep informado não existe').prepend(iconWarning);
    } else {
        $('#feed-valida-cep').text('');
    }
}