using System;

namespace TimerLibrary.ConsoleTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Timer timer = new Timer();

            FirstObserver firstObserver = new FirstObserver();
            SecondObserver secondObserver = new SecondObserver();

            firstObserver.Subscribe(timer);
            secondObserver.Subscribe(timer);

            timer.Start(15);

            Console.ReadKey();
        }
    }
}
