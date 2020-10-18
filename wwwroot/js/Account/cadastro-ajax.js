
$('#btn-cadastra-usuario').on('click', (e) => {
    e.preventDefault();
    let dados = getValueForInputsCadastro()
    $.post('/Account/CadastroAjax', dados, (response) => {
        console.log(response);
    });
});

function getValueForInputsCadastro(){
    let data = {
       Nome: $('#Nome').val(),
       Sobrenome: $('#Sobrenome').val(),
       Cpf: $('#Cpf').val(),
       UserName: $('#UserName').val(),
       Password: $('#Password').val()
    }
    return data;
}

$('.btn-close-feed-invalid').on('click', (e) => {
    e.preventDefault();
    divFeedInvalid.hide("slow");
});

function executaSpinner(){
    $('.text-login-btn').text('');
    divSpinnerLoading.show();
}

function removeSpinner(){
    setTimeout(() => {
        divSpinnerLoading.hide();
        $('.text-login-btn').text("CADASTRAR");
    }, timeCarregamentoPadrao);
}

function exibiFeedback(mensage){
    setTimeout(() => {
        $('.mensage-invalid-user').text(mensage);
        divFeedInvalid.show("medium");
    }, timeCarregamentoPadrao);   
}
