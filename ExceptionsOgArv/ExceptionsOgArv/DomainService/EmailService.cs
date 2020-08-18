using System;
using System.Collections.Generic;
using System.Text;
using ExceptionsOgArv.Exceptions;

namespace ExceptionsOgArv
{
    class EmailService : IEmailService
    {
        public bool Send(Email email)
        {
            throw new InvalidEmailAdressException();
        }
    }
}
