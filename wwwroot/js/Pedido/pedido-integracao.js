
$('#consultar-cep').on('blur', () => {
    $.get("https://viacep.com.br/ws/" + $('#consultar-cep').val() + "/json/", (response) => {
        console.log(response);
    });
});