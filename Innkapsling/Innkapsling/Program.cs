using System;
using System.Linq;

namespace Innkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangles = new Rectangle[]
            {
                new Rectangle(7, 3),
                new Rectangle(10, 5),
                new Rectangle(20, 30),
            };
            var totalArea = rectangles.Sum(r => r.Area());
            Console.WriteLine(totalArea);

        }
    }
}
