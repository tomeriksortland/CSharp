using System;

namespace ExceptionsOgArv.Exceptions
{
    class DatabaseUnresponiseException : CustomApplicationException
    {
        public DatabaseUnresponiseException(Exception innerException)
        :base("", innerException)
        {
            
        }
    }
}
