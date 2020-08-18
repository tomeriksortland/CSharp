using System;
using System.Threading;

namespace AbaxOppgaven
{
    class Båt : Kjøretøy
    {
        private int _bruttotonnasje { get; }

        public Båt(Kjøretøytype type, string kjennemerke, int effekt, int? maksfart, int bruttotonnasje, Kjøretøyklasse? kjøretøyKlasse) : base(type, kjennemerke, effekt, maksfart, kjøretøyKlasse)
        {
            _bruttotonnasje = bruttotonnasje;
        }



        public void SkrivBåtInfo()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{Kjøretøytype.Båt}" + "\n" +
                              $"Reg.nr = {Kjennemerke}" + "\n" +
                              $"Effekt = {Effekt}kw" + "\n" +
                              $"Maksfart = {Maksfart} knop" + "\n" +
                              $"Bruttotonnasje = {_bruttotonnasje}kg" + "\n");

        }
    }
}
