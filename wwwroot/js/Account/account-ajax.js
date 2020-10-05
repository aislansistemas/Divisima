
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
        console.log(response);
    });
});

function getValueForInputsLogin(){
    let data = {
        UserName: $('#UserName').val(),
        Password: $('#Password').val()
    };
    return data;
}