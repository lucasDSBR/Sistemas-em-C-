using System;

namespace ReservaTryCatch.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        
        } 
    }
}
