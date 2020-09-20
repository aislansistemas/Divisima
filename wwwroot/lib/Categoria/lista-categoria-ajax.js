$( () => {
    
    $.get("/Admin/Categoria/GetAllJson", (dados) => {
        montaTabelaCategoria(dados);
    })
    .fail().always();;

});