
function getTamanhoFormatado(tamanho){
    switch(tamanho){
        case 0 :
            return "PP";
        case 1 :
            return "P";
        case 2 :
            return "M";
        case 3 :
            return "G";
        case 4 :
            return "GG";
        case 5 :
            return "Extra G";  
        default :
            return "";             
    }
}

function getValorFormatado(valor){
    let valorFormatado = valor.toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
    return valorFormatado; 
}

