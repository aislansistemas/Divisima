$(getUsuarios());

function getUsuarios(){
    $.get('/Admin/Usuario/GetUsers', (response) => {
        montaTabelaUsuario(response);
    })
}