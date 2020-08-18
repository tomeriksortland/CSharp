using System;
using ExceptionsOgArv.ApplicationService;
using ExceptionsOgArv.Exceptions;

namespace ExceptionsOgArv
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new SubscriptionService(new EmailService(), new RegistrationRepostory());

            try
            {
                service.Subscribe("tomerik@getacademy.no");
            }
            catch (DatabaseUnresponiseException)
            {
                Console.WriteLine("Lagringen i databasen feilet. Prøv igjen om litt.");
            }
            catch(UnknownErrorException)
            {
                Console.WriteLine("Ukjent feil. Prøv igjen.");
            }
        }
    }
}
