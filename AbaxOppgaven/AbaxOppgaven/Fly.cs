using System;
using System.Threading;

namespace AbaxOppgaven
{
    class Fly : Kjøretøy
    {
        private int _vingespenn { get; }
        private int _lasteevne { get; }
        private int _egenvekt { get; }

        public Fly(Kjøretøytype type, string kjennemerke, int effekt, int? maksfart, int vingespenn, int lasteevne, int egenvekt, Kjøretøyklasse? kjøretøyKlasse) : base(type, kjennemerke, effekt, maksfart, kjøretøyKlasse)
        {
            _vingespenn = vingespenn;
            _lasteevne = lasteevne;
            _egenvekt = egenvekt;
        }

        public void SkrivFlyInfo()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{Kjøretøytype.Fly}" + "\n" +
                              $"Reg.nr = {Kjennemerke}" + "\n" +
                              $"Effekt = {Effekt}kw" + "\n" +
                              $"Vingespenn = {_vingespenn}m" + "\n" +
                              $"Lasteevne = {_lasteevne}" +"\n" +
                              $"Evenvekt = {_egenvekt} tonn" + "\n" +
                              $"Kjøretøy klasse = {Kjøretøyklasse.Jetfly}" + "\n");
        }

        public void KjørFly()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Fly ber om tillatelse til å fly, venter på klar signal" + "\n");
            Thread.Sleep(1000);
            Console.WriteLine("Flyet har fått tillatelse til å fly" + "\n");
            Thread.Sleep(1000);
            Console.WriteLine($"Fly med kjennemerke {Kjennemerke} tar av fra rullebanen" + "\n");
        }
    }
}
