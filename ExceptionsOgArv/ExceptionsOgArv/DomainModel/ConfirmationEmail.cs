using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsOgArv
{
    class ConfirmationEmail : Email
    {
        public ConfirmationEmail(string emailAdress, Guid confirmationCode) 
            : base(emailAdress, null)
        {
            var url = $"www.tjeneste.no/verify?email={emailAdress}&code={confirmationCode}";
            HtmlContent = $"<a href=\"https://{url}\">Tyrkk her for å verifisere</a>";
        }
    }
}
