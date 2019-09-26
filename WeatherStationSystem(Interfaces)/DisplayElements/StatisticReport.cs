using System;
using System.Collections.Generic;
using System.Linq;
using WeatherStationSystem_Interfaces_.Interfaces;

namespace WeatherStationSystem_Interfaces_.DisplayElements
{
    /// <summary>
    /// StatisticReport class - observer
    /// </summary>
    /// <seealso cref="WeatherStationSystem_Interfaces_.Interfaces.IObserver" />
    /// <seealso cref="WeatherStationSystem_Interfaces_.Interfaces.IPrint" />
    public class StatisticReport : IObserver, IPrint
    {
        private IObservable weatherData;

        List<double> temperatures = new List<double>();
        List<double> pressures = new List<double>();
        List<double> humidities = new List<double>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticReport"/> class.
        /// </summary>
        /// <param name="observable">The observable.</param>
        public StatisticReport(IObservable observable)
        {
            weatherData = observable;
            observable.Register(this);
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            var printTemperatureStatistics = $"Average/Maximum/Minimum temperature - {temperatures.Average()}, {temperatures.Max()}, {temperatures.Min()}";
            var printHumidityStatistics = $"Average/Maximum/Minimum humidity - {humidities.Average()}, {humidities.Max()}, {humidities.Min()}";
            var printPressureStatistics = $"Average/Maximum/Minimum pressure - {pressures.Average()}, {pressures.Max()}, {pressures.Min()}";
            Console.WriteLine("{0}\n{1}\n{2}",printTemperatureStatistics, printHumidityStatistics, printPressureStatistics);//колич знаков после запятой
        }

        /// <summary>
        /// Updates the specified temperature.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <param name="humidity">The humidity.</param>
        /// <param name="pressure">The pressure.</param>
        public void Update(double temperature, double humidity, double pressure)
        {
            temperatures.Add(temperature);
            pressures.Add(pressure);
            humidities.Add(humidity);
            Print();
        }

        /// <summary>
        /// Averages the specified measures.
        /// </summary>
        /// <param name="measures">The measures.</param>
        /// <returns></returns>
        private double Average(List<double> measures)
        {
            double sum = 0;

            foreach (var measure in measures)
            {
                sum += measure;
            }

            return sum / measures.Count;
        }
    }
}
