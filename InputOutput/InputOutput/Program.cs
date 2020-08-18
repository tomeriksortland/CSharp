using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.WriteLine("Hello. What's you're name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", how old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 30)
            {
                Console.WriteLine();
            }
            else
            {

            }
        }
    }
}
