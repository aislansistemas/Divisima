
$('#btn-login').on('click', (e) => {
    e.preventDefault();
    executaSpinner();
    let dados = getValueForInputsLogin();
    $.post('/Account/LoginAjax', dados, (response) => {
        if(response == "sucesso") {
            executaSpinner();
            window.location.href = "/";
        } else {
            removeSpinner('LOGIN');
            exibiFeedback(response);
            this.form.reset;
        }
    });
});

function getValueForInputsLogin(){
    let data = {
        UserName: $('#UserName').val(),
        Password: $('#Password').val()
    };
    return data;
}

$('.btn-close-feed-invalid').on('click', (e) => {
    e.preventDefault();
    divFeedInvalid.hide("slow");
});

function exibiFeedback(mensage){
    setTimeout(() => {
        $('.mensage-invalid-user').text(mensage);
        divFeedInvalid.show("medium");
    }, timeCarregamentoPadrao);   
}