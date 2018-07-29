using System;

namespace TimerLibrary.ConsoleTests
{
    public class FirstObserver
    {
        public void Subscribe(Timer timer) => timer.TimeOut += this.Message;

        public void Unsubscribe(Timer timer) => timer.TimeOut -= this.Message;

        public void Message(object sender, TimeOutEventArgs e)
        {
            Console.WriteLine($"First observer: {e.TimerInfo}");
        }
    }
}
