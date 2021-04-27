using System;

namespace Divisima.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string mensagem) : base (mensagem){

        }
    }
}