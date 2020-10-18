
$('#btn-cadastra-usuario').on('click', (e) => {
    e.preventDefault();
    let dados = getValueForInputsCadastro();
    let erros = validaCadastro(dados);
    if(erros.length <= 0) {
        $.post('/Account/CadastroAjax', dados, (response) => {
            console.log(response);
        });
    } else {
        console.log(erros);
    }    
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


function validaCadastro(dados){
    let erros = [];

    if(dados.Nome.length == 0){
        erros.push('O nome precisa ser informado');
    }

    if(dados.Sobrenome == 0){
        erros.push('O Sobrenome precisa ser informado');
    }

    if(dados.Cpf == 0){
        erros.push('O Cpf precisa ser informado');
    }

    if(dados.UserName == 0){
        erros.push('O E-mail precisa ser informado');
    }

    if(dados.Password < 6){
        erros.push('A senha precisa ter no mínimo 6 digitos, letras maiúsculas e minúsculas e numeros');
    }
   
    return erros;
}