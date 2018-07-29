using System;

namespace TimerLibrary
{
    /// <summary>
    /// Timer class.
    /// </summary>
    public class Timer
    {
        /// <summary>
        /// Event which occurs when specicfic time is out.
        /// </summary>
        public event EventHandler<TimeOutEventArgs> TimeOut = delegate { };

        /// <summary>
        /// Method which starts the timer.
        /// </summary>
        /// <param name="seconds">Seconds amount.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when seconds amount is less or equal to zero.</exception>
        public void Start(int seconds)
        {
            if (seconds <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(seconds)} can not be less or equal to zero.");
            }

            for (int i = seconds; i >= 0; i--)
            {
                Console.WriteLine("The timer is running.\n" + "Time left: {0} seconds", i);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }

            this.OnTimeOut(this, new TimeOutEventArgs(seconds));
        }

        protected virtual void OnTimeOut(object sender, TimeOutEventArgs e)
        {
            this.TimeOut?.Invoke(sender, e);
        } 
    }
}
