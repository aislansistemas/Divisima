function montaTabelaUsuario(dados){
    console.log(dados);
    dados.forEach(usuario => {
        let tr = $('<tr>');
        let tdNome = $('<td>').addClass('td-nome').text(usuario.nome);
        let tdEmail = $('<td>').addClass('td-email').text(usuario.userName);
        let tdPerfil = $('<td>').addClass('td-perfil').text(usuario.perfilUsuario);
        tr.append(tdNome);
        tr.append(tdEmail);
        tr.append(tdPerfil);
        $('#tabela-list-usuarios').append(tr);
    });
}