using System;
using System.Threading;

namespace CountDownSystem
{
    /// <summary>
    /// Class TimesUp 
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class TimesUpEventArgs: EventArgs
    {
        private readonly string message;

        public TimesUpEventArgs(int timeWait)
        {
            Thread.Sleep(timeWait);
            message = "Time's up!";
        }

        public string Message { get { return message; } }
    }
}
