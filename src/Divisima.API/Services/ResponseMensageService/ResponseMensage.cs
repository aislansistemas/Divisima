using System.Collections.Generic;
using System.Collections.Specialized;
using Divisima.Enums.StatusMensageEnums;

namespace Divisima.Services.ResponseMensageService
{
    public class ResponseMensage
    {
        public static OrderedDictionary GetMensage(string statusMensage, string mensage)
        {
            var mensagemFormatada = new OrderedDictionary();
            mensagemFormatada.Add("status", statusMensage);
            mensagemFormatada.Add("mensagem", mensage);

            return mensagemFormatada;
        }
    }
}