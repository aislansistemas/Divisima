using System;

namespace Divisima.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string mensagem) : base (mensagem) {}
    }
}