
$(getUsuarios());

var numberPage = 1;
var limit = 10;

function getUsuarios(){
    $.get('/Admin/Usuario/GetUsers', {numberPage, limit},(response) => {
        montaTabelaUsuario(response);
    })
}

function carregaMaisUsuarios(){
    numberPage++;
    $.get('/Admin/Usuario/GetUsers', {numberPage, limit},(response) => {
        montaTabelaUsuario(response);
    })
}