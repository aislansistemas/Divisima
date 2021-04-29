function montaTabelaUsuario(dados){
    dados.forEach(usuario => {
        let tr = $('<tr>');
        let tdNome = $('<td>').addClass('td-nome').text(usuario.nome);
        let tdEmail = $('<td>').addClass('td-email').text(usuario.userName);
        tr.append(tdNome);
        tr.append(tdEmail);
        $('#tabela-list-usuarios').append(tr);
    });
}