using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsOgArv
{
    interface IRegistrationRepostory
    {
        bool Create(Registration registration);
        Registration Read(string email);
    }
}
