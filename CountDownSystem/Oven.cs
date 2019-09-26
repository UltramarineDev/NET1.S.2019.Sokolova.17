using System;

namespace CountDownSystem
{
    /// <summary>
    /// Oven class - observer
    /// </summary>
    public class Oven
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Oven"/> class.
        /// </summary>
        /// <param name="countDownTimer">The count down timer.</param>
        public Oven(CountDownTimer countDownTimer)
        {
            countDownTimer.NewTimeIsUp += DisplayOvenMessage;
        }

        private void DisplayOvenMessage(object sender, TimesUpEventArgs e)
        {
            Console.WriteLine("Oven received: {0}", e.Message);
        }

        /// <summary>
        /// Unregisters the specified count down timer.
        /// </summary>
        /// <param name="countDownTimer">The count down timer.</param>
        public void Unregister(CountDownTimer countDownTimer)
        {
            countDownTimer.NewTimeIsUp -= DisplayOvenMessage;
        }
    }
}
