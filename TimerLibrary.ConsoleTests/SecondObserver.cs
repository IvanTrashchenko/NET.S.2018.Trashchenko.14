using System;

namespace TimerLibrary.ConsoleTests
{
    public class SecondObserver
    {
        public void Subscribe(Timer timer) => timer.TimeOut += this.Message;

        public void Unsubscribe(Timer timer) => timer.TimeOut -= this.Message;

        public void Message(object sender, TimeOutEventArgs e)
        {
            Console.WriteLine($"Second observer: {e.TimerInfo}");
        }
    }
}
