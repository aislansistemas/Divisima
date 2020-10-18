
var divFeedInvalid =  $('.feed-user-invalid');
var divSpinnerLoading = $('.div-spinner-loading');
const timeCarregamentoPadrao = 700;

$(
    divFeedInvalid.hide(),
    divSpinnerLoading.hide()
);

function executaSpinner(){
    $('.text-login-btn').text('');
    divSpinnerLoading.show();
}

function removeSpinner(){
    setTimeout(() => {
        divSpinnerLoading.hide();
        $('.text-login-btn').text("LOGIN");
    }, timeCarregamentoPadrao);
}