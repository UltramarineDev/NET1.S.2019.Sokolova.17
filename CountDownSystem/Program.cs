namespace CountDownSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDownTimer countDownTimer = new CountDownTimer();
            Oven oven = new Oven(countDownTimer);
            Microwave microwave = new Microwave(countDownTimer);

            countDownTimer.SimulateNewTimer(1000);
            countDownTimer.SimulateNewTimer(1500);

            oven.Unregister(countDownTimer);
            countDownTimer.SimulateNewTimer(1000);
        }
    }
}
