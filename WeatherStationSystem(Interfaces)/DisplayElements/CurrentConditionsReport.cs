using System;
using WeatherStationSystem_Interfaces_.Interfaces;

namespace WeatherStationSystem_Interfaces_.DisplayElements
{
    /// <summary>
    /// CurrentConditionsReport class
    /// </summary>
    /// <seealso cref="WeatherStationSystem_Interfaces_.Interfaces.IObserver" />
    /// <seealso cref="WeatherStationSystem_Interfaces_.Interfaces.IPrint" />
    class CurrentConditionsReport : IObserver, IPrint
    {
        private double temperature;
        private double pressure;
        private double humidity;

        private IObservable weatherData;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentConditionsReport"/> class.
        /// </summary>
        /// <param name="observable">The observable.</param>
        public CurrentConditionsReport(IObservable observable)
        {
            weatherData = observable;
            observable.Register(this);
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            var printString = $"Current conditions:\nTemperature is {temperature} degrees,\nHumidity is {humidity}%\nPressure is {pressure} ";
            Console.WriteLine(printString);
        }

        /// <summary>
        /// Updates the specified temperature.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <param name="humidity">The humidity.</param>
        /// <param name="pressure">The pressure.</param>
        public void Update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Print();
        }
    }
}
