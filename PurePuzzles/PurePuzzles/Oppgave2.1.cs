using System;
using System.Collections;

namespace PurePuzzles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Skriv inn tekst: ");
            string[] Words = { };
            var line = Console.ReadLine();
            var charsInCurrentWord = 0;
            foreach (var character in line)
            {
                var isSpace = character == ' ';
                if (!isSpace)
                {
                    charsInCurrentWord++;
                }
                else
                {
                    if (charsInCurrentWord == 0) charsInCurrentWord++;
                    
                }
            }
            Console.WriteLine("Her er det totalt: " + charsInCurrentWord + " bokstaver.");









            /*
             * Oppgave 2.1
             *
             * int[] hashTags = { 8, 6, 4, 2 };

            for (int rows = 0; rows < hashTags.Length; rows++)
            {
                for (int space = 0; space < new[] { 1, 2, 3, 4 }[rows]; space++)
                {
                    Console.Write(" ");
                }

                for (int hashtag = 0; hashtag < hashTags[rows]; hashtag++)
                {
                    Console.Write("#");
                }
                Console.WriteLine(" ");
            }
             */


            /*
             * Oppgave 2.2
             *
             * int[] hasharray = { 2, 4, 6, 8, 8, 6, 4, 2 };
            int makespaces = 12;

            for (int rows = 0; rows < hasharray.Length; rows++)
            {
                for (int space = 0; space <= (makespaces - hasharray[rows]) / 2; space++)
                {
                    Console.Write(" ");
                }
                for (int hashtag = 0; hashtag < hasharray[rows]; hashtag++)
                {
                    Console.Write("#");
                }
                Console.WriteLine(" ");
            }


            Oppgave 2.3

              int rows = 5;
            int Collums = 7;
         ;
            for (int i = -5; i <= rows; i++)
            {
                if(i == 0) continue;
                var hashRight = (rows - Math.Abs(i)) * 2;
                for (int j = -7; j <= Collums; j++)
                {
                    var writtenHash = Collums - Math.Abs(j);


                    if (rows - Math.Abs(i) > Collums - Math.Abs(j))
                    {
                        writeBlank();
                        
                    }
                    else if (hashRight > writtenHash)
                    {
                        writeTags();
                    }
                    else
                    {
                        writeBlank();
                    }
                }
                startnewline();
            }
             */









        }

        private static void startnewline()
        {
            Console.WriteLine(" ");
        }

        private static void writeTags()
        {
            Console.Write("#");
        }

        private static void writeBlank()
        {
            Console.Write(" ");
        }
    }
}
