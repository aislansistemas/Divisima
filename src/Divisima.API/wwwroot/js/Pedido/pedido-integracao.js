
$('#consultar-cep').on('blur', () => {
    $.get("https://viacep.com.br/ws/" + $('#consultar-cep').val() + "/json/", (response) => {
        if(!response.erro) {
            $('#cidade').attr('disabled', 'true').val(response.localidade);
            $('#estado').attr('disabled', 'true').val(response.uf);
            exibirFeedCepInvalido(false);
        } else {
            $('#consultar-cep').val('');
            $('#cidade').val('');
            $('#estado').val('');
            exibirFeedCepInvalido(true);
        }
    });
});

function exibirFeedCepInvalido(exibir){
    let iconWarning = $('<i>').addClass('fa fa-exclamation-circle text-danger');
    if(exibir){
        $('#feed-valida-cep').text('');
        $('#feed-valida-cep').text(' Ops! O Cep informado não existe').prepend(iconWarning);
    } else {
        $('#feed-valida-cep').text('');
    }
}
