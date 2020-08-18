namespace AbaxOppgaven
{
    public class Kjøretøy
    {
        public Kjøretøytype Type { get; }
        public string Kjennemerke { get; }
        public int Effekt { get; }
        public int? Maksfart { get; }
        public Kjøretøyklasse? KjøretøyKlasse { get; }


        public Kjøretøy(Kjøretøytype type, string kjennemerke, int effekt, int? maksfart, Kjøretøyklasse? kjøretøyKlasse)
        {
            Type = type;
            Kjennemerke = kjennemerke;
            Effekt = effekt;
            Maksfart = maksfart;
            KjøretøyKlasse = kjøretøyKlasse;
        }
    }
}
