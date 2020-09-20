function montaTabelaCategoria(dados){
    for(let i = 0; i < dados.length; i++){
        let categoria = dados[i];
        let tr = $('<tr>');
        let tdNome = $('<td>').addClass('td-nome').text(categoria.nome);
        let tdAtivo = $('<td>').addClass('td-ativo').text( getValueAtivo(categoria.ativo) );
        tr.append(tdNome);
        tr.append(tdAtivo);
        $('#tabela-list-categoria').append(tr);
    }
}

function getValueAtivo(valor){
    if(valor === 1){
        return "Ativo";
    } 
    return "Inativo";
}