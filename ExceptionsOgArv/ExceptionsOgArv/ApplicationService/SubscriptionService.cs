using System;
using ExceptionsOgArv.ApplicationService;
using ExceptionsOgArv.Exceptions;

namespace ExceptionsOgArv
{
    class SubscriptionService
    {
        private IEmailService _emailService;
        private IRegistrationRepostory _registrationRepostory;

        public SubscriptionService(IEmailService emailService, IRegistrationRepostory registrationRepostory)
        {
            _emailService = emailService;
            _registrationRepostory = registrationRepostory;
        }

        public void Subscribe(string emailAdress)
        {
            var registration = new Registration(emailAdress);
            try
            {

            }
            catch (NotImplementedException e)
            {
                throw new DatabaseUnresponiseException(e);
            }
            catch (Exception e)
            {
                throw new UnknownErrorException(e);
            }
            
            var email = new ConfirmationEmail(emailAdress, registration.VerificationCode);

            try
            {
                _emailService.Send(email);
            }
            catch (NotImplementedException e)
            {
                throw new MailServerException();
            }
            catch (CustomApplicationException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new UnknownErrorException(e);
            }
        }
    }
}
