using System;
using System.Threading;
using PomodoroEngine;

namespace InterfacePomodoroOppgave
{
    public class Program : INotifyObject
    {
        public static void Main(string[] args)
        {
            var program = new Program();
            Console.ReadLine();
        }

        public Program()
        {
            var pomodoro = new Pomodoro(this, 1);
            pomodoro.Start();
        }

        public void Tick(int minutes, int seconds)
        {
          Console.Clear();
          if (seconds == 0 && minutes == 0)
          {
              Console.WriteLine("Ta en pause!");
              Environment.Exit(0);
          }
          Console.WriteLine();
        }
    }
}
