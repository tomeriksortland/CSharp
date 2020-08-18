using System;
using System.Threading;
using RandomBoxes;

namespace Oppgave1Arv
{
    internal class Program
    {
        private const int Width = 50;
        private const int Height = 20;

        private static void Main()
        {
            var shapes = CreateShapes();
            var n = 20;
            while (n-- > 0)
            {
                Show(shapes);
                foreach (var shape in shapes)
                {
                    shape.Move();
                }
                Thread.Sleep(400);
            }
        }

        private static Shape[] CreateShapes()
        {
            var random = new Random();
            var shapes = new Shape[5];
            shapes[0] = new Text(5, 10, "Hurra!", random);
            for (var i = 1; i < shapes.Length; i++)
            {
                if (random.Next(0, 2) == 0)
                    shapes[i] = new Rectangle(random, Width, Height);
                else
                    shapes[i] = new Triangle(random, Height);
            }
            return shapes;
        }

        private static void Show(Shape[] shapes)
        {
            Console.Clear();
            for (var row = 0; row < Height; row++)
            {
                for (var col = 0; col < Width; col++)
                {
                    var hasFoundCharacterToPrint = false;
                    foreach (var shape in shapes)
                    {
                        var character = shape.GetCharacter(row, col);
                        if (character == null) continue;
                        Console.Write(character);
                        hasFoundCharacterToPrint = true;
                        break;
                    }
                    if (!hasFoundCharacterToPrint) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}