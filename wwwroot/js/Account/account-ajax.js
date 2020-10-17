
var divFeedInvalidUser =  $('.feed-user-invalid');

$(divFeedInvalidUser.hide());

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

$('#btn-login').on('click', (e) => {
    e.preventDefault();
    let dados = getValueForInputsLogin();
    $.post('/Account/LoginAjax', dados, (response) => {
        if(response == "sucesso") {
            window.location.href = "/Produto/Index";
        } else {
            $('.mensage-invalid-user').text(response);
            divFeedInvalidUser.show("medium");
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
    divFeedInvalidUser.hide("slow");
});