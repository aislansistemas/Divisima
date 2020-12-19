using System;

namespace Divisima.Services.Exceptions
{
    public class InvalidModelStateException : ApplicationException
    {
        public InvalidModelStateException(string mensagem) : base (mensagem) {}
    }
}