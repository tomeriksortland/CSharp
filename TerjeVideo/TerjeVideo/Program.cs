using System;

namespace TerjeVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Terje");
            var student2 = new Student("Tom Erik", "Sortland");

            Console.WriteLine(student1.GetFirstName() + " " + student1.GetLastName());
            Console.WriteLine(student2.GetFirstName() + " " + student2.GetLastName());

            student1.RenameFirstName();
            Console.WriteLine(student1.GetFirstName());
        }
    }
}
