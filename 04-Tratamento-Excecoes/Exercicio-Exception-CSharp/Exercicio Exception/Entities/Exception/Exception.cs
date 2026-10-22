using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Exception.Entities.Exception
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        { 
        }
    }
}
