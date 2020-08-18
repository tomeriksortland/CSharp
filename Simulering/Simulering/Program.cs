using System;

namespace Simulering
{
    class Program
    {
        private static void Main()
        {
            var bottle1 = new Bottle(5);
            var bottle2 = new Bottle(3);
            const int wantedVolume = 4;

            var numberOfOperations = 1;
            while (true)
            {
                Console.WriteLine("Prøver med " + numberOfOperations + "operasjon(er)");
                var operations = new int[numberOfOperations];
                while (true)
                {
                    DoOperations(operations, bottle1, bottle2);
                    if (bottle1.Content == wantedVolume || bottle2.Content == wantedVolume)
                    {
                        Console.WriteLine("Fant løsning:");
                        ShowOperations(operations);
                        Environment.Exit(0);
                    }

                    var success = UpdateOperations(operations);
                    if (!success) break;
                }

                numberOfOperations++;
            }
        }

        private static bool UpdateOperations(int[] operations)
        {
            int i;
            for (i = operations.Length - 1; i >= 0; i--)
            {
                if (operations[i] < 8)
                {
                    operations[i]++;
                    break;
                }
                operations[i] = 0;
            }

            return i != -1;
        }

        private static void ShowOperations(int[] operations)
        {
            var text = new string[]
            {
                "Fylle flaske 1 fra springen",
                "Fylle flaske 2 fra springen",
                "Tømme flaske 1 i flaske 2",
                "Tømme flaske 2 i flaske 1",
                "Fylle opp flaske 2 med flaske 1",
                "Fylle opp flaske 1 med flaske 2",
                "Tømme ut flaske 1",
                "Tømme ut flaske 2"

            };
            foreach (var operation in operations)
            {

                Console.WriteLine(text[operation]);
            }
        }

        private static void DoOperations(int[] operations, Bottle bottle1, Bottle bottle2)
        {
            bottle1.Empty();
            bottle2.Empty();
            foreach (var operation in operations) { 
            
               
                if (operation == 0) bottle1.FillToTopFromTap();         // Fylle flaske 1 fra springen
                else if (operation == 1) bottle2.FillToTopFromTap();    // Fylle flaske 2 fra springen
                else if (operation == 2)                                // Tømme flaske 1 i flaske 2
                {
                    if (bottle1.IsEmpty()) break;
                    var success = bottle2.Fill(bottle1.Empty());
                    if (!success) break;
                }
                else if (operation == 3)                                // Tømme flaske 2 i flaske 1
                {
                    if (bottle2.IsEmpty()) break;
                    var success = bottle1.Fill(bottle2.Empty());
                    if (!success) break;
                }
                else if (operation == 4)                                // Fylle opp flaske 2 med flaske 1
                {
                    var success = bottle2.FillToTop(bottle1);
                    if (!success) break;
                }

                else if (operation == 5)                                // Fylle opp flaske 1 med flaske 2
                {
                    var success = bottle1.FillToTop(bottle2);
                    if (!success) break;
                }
                else if (operation == 6)                                // Tømme flaske 1 
                {
                    bottle1.Empty();
                }

                else if (operation == 7)                                // Tømme flaske 2
                {
                    bottle2.Empty();
                }
            }


        }
    }
}
