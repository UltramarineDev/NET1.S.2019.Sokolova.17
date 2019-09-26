using System;

namespace CountDownSystem
{
    /// <summary>
    /// Class CountDownTimer
    /// </summary>
    public class CountDownTimer
    {
        /// <summary>
        /// Event NewTimeIsUp
        /// </summary>
        public event EventHandler<TimesUpEventArgs> NewTimeIsUp = delegate { };

        private void TimerBegin(object sender, TimesUpEventArgs e)
        {
            NewTimeIsUp?.Invoke(this, e);
        }

        /// <summary>
        /// Simulates the new timer.
        /// </summary>
        /// <param name="timeWaitMilliseconds">The time wait milliseconds.</param>
        public void SimulateNewTimer(int timeWaitMilliseconds)
        {
            TimerBegin(this, new TimesUpEventArgs(timeWaitMilliseconds));
        }
    }
}
