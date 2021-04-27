
var divFeedInvalid =  $('.feed-user-invalid');
var divSpinnerLoading = $('.div-spinner-loading');
const timeCarregamentoPadrao = 700;

$(
    divFeedInvalid.hide(),
    divSpinnerLoading.hide()
);

function executaSpinner(){
    $('.text-btn-post').text('');
    divSpinnerLoading.show();
}

function removeSpinner(text){
    setTimeout(() => {
        divSpinnerLoading.hide();
        $('.text-btn-post').text(text);
    }, timeCarregamentoPadrao);
}

