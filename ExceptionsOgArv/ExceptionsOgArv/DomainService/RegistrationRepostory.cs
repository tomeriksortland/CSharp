using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsOgArv
{
    class RegistrationRepostory : IRegistrationRepostory
    {
        public bool Create(Registration registration)
        {

            throw new NotImplementedException();
        }

        public Registration Read(string email)
        {
            throw new NotImplementedException();
        }
    }
}
