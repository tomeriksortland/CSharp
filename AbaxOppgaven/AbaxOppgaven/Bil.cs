using System;
using System.Threading;

namespace AbaxOppgaven
{
    public class Bil : Kjøretøy
    {
        private string _farge { get; }


        public Bil(Kjøretøytype type, string kjennemerke, int effekt, int? maksfart, string farge, Kjøretøyklasse? kjøretøyKlasse) : base(type, kjennemerke, effekt, maksfart, kjøretøyKlasse)
        {
            _farge = farge;
        }

        public void SkrivBilInfo()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{Kjøretøytype.Bil}" + "\n" +
                              $"Reg.nr = {Kjennemerke}" + "\n" + 
                              $"Effekt = {Effekt}" + "\n" +
                              $"Maksfart = {Maksfart}km/t" + "\n" +
                              $"Farge = {_farge}" + "\n" +
                              $"Kjøretøyklasse = {Kjøretøyklasse.LettKjøretøy}" + "\n");
        }


        public void KjørBil()
        {
            Console.WriteLine($"Starter bil med kjennemerke {Kjennemerke}...." + "\n");
            Thread.Sleep(1000);
            Console.WriteLine($"Bil med {Kjennemerke} kjører avgårde." + "\n");
        }
    }
}
