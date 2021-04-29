$(cerregarPedidos)

function cerregarPedidos() {
    $.get("/Admin/Pedido/CarregarPedidoAjax", (response) => {
        $('#lista-pedidos').html(response);
    });
}

function vizualizarDetalhes(pedidoId) {
    $.get("/Admin/Pedido/DetalhesPedidoAjax", {pedidoId},(response) => {
        console.log(response);
        $('#detalhes-pedido').html(response);
    });
}