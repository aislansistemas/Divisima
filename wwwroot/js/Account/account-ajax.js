
$('#btn-cadastra-usuario').on('click', (e) => {
    e.preventDefault();
    $.post('/Account/CadastroAjax', getValueForInputs(), (response) => {
        console.log(response);
    });
});


function getValueForInputs(){
    var data = {
       UserName: $('.UserName').val(),
       Sobrenome: $('.Sobrenome').val(),
       Cpf: $('.Cpf').val(),
       Email: $('.Email').val(),
       Password: $('.Password').val()
    }
    return data;
}