using System;
// É uma exceção de dominio
namespace CreatingPersonalizedExceptions.Entities.Exceptions
{
    // É uma subclasse de ApplicationException
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
