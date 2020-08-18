using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsOgArv
{
    interface IEmailService
    {
        bool Send(Email email);
    }
}
