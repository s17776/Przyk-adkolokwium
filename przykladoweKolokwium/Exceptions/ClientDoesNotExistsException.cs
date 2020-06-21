using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKolokwium.Exceptions
{
    public class ClientDoesNotExistsException : Exception
    {
        public ClientDoesNotExistsException()
        {
        }

        public ClientDoesNotExistsException(string message) : base(message)
        {
        }

        public ClientDoesNotExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
