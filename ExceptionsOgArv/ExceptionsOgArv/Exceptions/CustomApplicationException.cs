using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsOgArv.Exceptions
{
    class CustomApplicationException : ApplicationException
    {
        public CustomApplicationException()
        {
            
        }

        public CustomApplicationException(string msg, Exception inner) : base(msg, inner)
        {
            
        }
    }
}
