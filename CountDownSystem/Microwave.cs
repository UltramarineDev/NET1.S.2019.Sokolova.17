using System;

namespace CountDownSystem
{
    /// <summary>
    /// Class Microwave - observer
    /// </summary>
    class Microwave
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Microwave"/> class.
        /// </summary>
        /// <param name="countDownTimer">The count down timer.</param>
        public Microwave(CountDownTimer countDownTimer)
        {
            countDownTimer.NewTimeIsUp += DisplayMicrowaveMessage;           
        }

        private void DisplayMicrowaveMessage(object sender, TimesUpEventArgs e)
        {
            Console.WriteLine("Microvawe received: {0}", e.Message);
        }

        /// <summary>
        /// Unregisters the specified count down timer.
        /// </summary>
        /// <param name="countDownTimer">The count down timer.</param>
        public void Unregister(CountDownTimer countDownTimer)
        {
            countDownTimer.NewTimeIsUp -= DisplayMicrowaveMessage;
        }

    }
}
