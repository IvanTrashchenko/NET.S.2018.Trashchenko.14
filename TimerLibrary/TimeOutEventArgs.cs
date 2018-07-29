using System;

namespace TimerLibrary
{
    /// <summary>
    /// Information about TimeOut event of <see cref="Timer"/>.
    /// </summary>
    public class TimeOutEventArgs : EventArgs
    {
        /// <summary>
        /// Amount of seconds.
        /// </summary>
        private readonly int seconds;

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOutEventArgs"/> class with specific seconds amount.
        /// </summary>
        /// <param name="seconds">Seconds amount.</param>
        public TimeOutEventArgs(int seconds)
        {
            this.seconds = seconds;
        }

        /// <summary>
        /// Message with timer's information.
        /// </summary>
        public string TimerInfo => $"Timer is set to {this.seconds} seconds.";
    }
}
