function montaTabelaCategoria(dados) {
    for(let i = 0; i < dados.length; i++){
        let categoria = dados[i];
        let tr = $('<tr>');
        let tdNome = $('<td>').addClass('td-nome').text(categoria.nome);
        let tdAtivo = $('<td>').addClass('td-ativo').text( getValueAtivo(categoria.ativo) );
        let tdBtnInative = $('<td>').addClass('td-btn-inative').append(getElementButton(categoria.categoriaId, categoria.nome, 'btn-danger', 'sm', 'Inativar', categoria.ativo));
        let tdBtnEdit = $('<td>').addClass('td-btn-edit').append(getElementButton(categoria.categoriaId, categoria.nome, 'btn-primary', 'sm', 'Editar', categoria.ativo));
        tr.append(tdNome);
        tr.append(tdAtivo);
        tr.append(tdBtnInative);
        tr.append(tdBtnEdit);
        $('#tabela-list-categoria').append(tr);
    }
}

function getValueAtivo(valor){
    if(valor === 1){
        return "Ativo";
    } 
    return "Inativo";
}


function getElementButton(id, nome, className, sizeBtn, text, ativo){
    btn = $('<button>');
    if(text === 'Inativar' && ativo === 1) {
        btn.attr('data-id', id)
        .attr('data-toggle', 'modal')
        .attr('data-target', '#ModalCentralizadoInativar')
        .addClass('btn ' + className + ' btn-' + sizeBtn + ' ' + text)
        .text(text)
        .on('click', () => {   
            setValueForInputs(id);
        });
        return btn; 
    } else if (text === 'Editar') {   
        btn.attr('data-id', id)
        .attr('data-toggle', 'modal')
        .attr('data-target', '#ModalCentralizadoEditar')
        .addClass('btn ' + className + ' btn-' + sizeBtn + ' ' + text)
        .text(text)
        .on('click', () => {   
            setValueForInputs(id, nome);
        });
        return btn;
    } else if (ativo === 0) {
        btn.attr('data-id', id)
        .attr('data-toggle', 'modal')
        .attr('data-target', '#ModalCentralizadoAtivar')
        .addClass('btn btn-success btn-sm Ativar')
        .text('Ativar')
        .on('click', () => {   
            setValueForInputs(id);
        });
        return btn;
    }
}

function setValueForInputs(id, nome = null){
    $('.id-categoria').val(id);
    $('.nome-categoria').val(nome);
}

