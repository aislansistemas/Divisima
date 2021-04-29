function setGifLoading(){
    let imgLoading = $('<img>').attr('src', 'img/carregamento.gif');
    $('.modal-content').prepend(imgLoading);
    return imgLoading;
}