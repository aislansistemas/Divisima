using System;

namespace Divisima.Services.Exceptions
{
    public class CreatedException : ApplicationException
    {
        public CreatedException(string mensagem) : base (mensagem){

        }
    }
}