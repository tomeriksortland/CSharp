using System;
using System.Collections.Generic;
using System.Text;
using ExceptionsOgArv.Exceptions;

namespace ExceptionsOgArv.ApplicationService
{
    class UnknownErrorException : CustomApplicationException
    {
        public UnknownErrorException(Exception innerException)
            : base("", innerException)
        {

        }
    }
}
