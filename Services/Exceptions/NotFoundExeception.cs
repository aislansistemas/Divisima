using System;

namespace Divisima.Services.Exceptions
{
    public class NotFoundExeception : ApplicationException
    {
        public NotFoundExeception(string mensagem) : base (mensagem)
        {
            
        }
    }
}