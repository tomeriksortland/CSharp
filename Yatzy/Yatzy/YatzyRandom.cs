using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzy
{
    public class YatzyRandom
    {
        private static YatzyRandom _instance;

        public static YatzyRandom Instace 
            => _instance ?? (_instance = new YatzyRandom());

        readonly Random _random = new Random();

        public int GetNumber()
        {
            return _random.Next(1, 6);
        }
    }
}
