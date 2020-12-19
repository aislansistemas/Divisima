using System;

namespace Divisima.Services.Exceptions
{
    public class InvalidArgumentException : ApplicationException
    {
        public InvalidArgumentException(string mensagem) : base (mensagem) {} 
    }
}