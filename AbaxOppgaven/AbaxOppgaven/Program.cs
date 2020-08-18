using System;

namespace AbaxOppgaven
{
    class Program
    {
        static void Main(string[] args)
        {
            var bil1 = new Bil(Kjøretøytype.Bil, "NF123456", 147, 200, "Grønn", Kjøretøyklasse.LettKjøretøy);
            bil1.SkrivBilInfo();
            var bil2 = new Bil(Kjøretøytype.Bil, "NF654321", 150, 195, "Blå", Kjøretøyklasse.LettKjøretøy);
            bil2.SkrivBilInfo();

            if (bil1 == bil2)
            {
                Console.WriteLine("Bil 1 og bil 2 er like\n");
            }
            else
            {
                Console.WriteLine("Bil 1 og bil 2 er ikke like\n");
            }
            
            var fly1 = new Fly(Kjøretøytype.Fly,"LN1234", 1000, null, 30, 2, 10, Kjøretøyklasse.Jetfly);
            fly1.SkrivFlyInfo();

            fly1.KjørFly();
            bil1.KjørBil();

            var båt1 = new Båt(Kjøretøytype.Båt,"ABC123", 100, 30, 500, null);
            båt1.SkrivBåtInfo();
        }
    }
}
