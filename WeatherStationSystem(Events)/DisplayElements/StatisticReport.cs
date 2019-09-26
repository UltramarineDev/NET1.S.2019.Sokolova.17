using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherStationSystem_Events_.DisplayElements
{
    public class StatisticReport
    {
        List<double> temperatures = new List<double>();
        List<double> pressures = new List<double>();
        List<double> humidities = new List<double>();

        public StatisticReport(WeatherData weatherData)
        {
            weatherData.NewMeasures += AddMeasuresToList;
            weatherData.NewMeasures += DisplayStatisticReport;
        }

        private void AddMeasuresToList(object sender, WeatherMeasuresEventArgs e)
        {
            temperatures.Add(e.Temperature);
            pressures.Add(e.Pressure);
            humidities.Add(e.Humidity);
        }

        private void DisplayStatisticReport(object sender, WeatherMeasuresEventArgs e)
        {
            var printTemperatureStatistics = $"Average/Maximum/Minimum temperature - {temperatures.Average()}, {temperatures.Max()}, {temperatures.Min()}";
            var printHumidityStatistics = $"Average/Maximum/Minimum humidity - {humidities.Average()}, {humidities.Max()}, {humidities.Min()}";
            var printPressureStatistics = $"Average/Maximum/Minimum pressure - {pressures.Average()}, {pressures.Max()}, {pressures.Min()}";
            Console.WriteLine("{0}\n{1}\n{2}", printTemperatureStatistics, printHumidityStatistics, printPressureStatistics);//колич знаков после запятой
        }

        public void Unregister(WeatherData weatherData)
        {
            weatherData.NewMeasures -= AddMeasuresToList;
            weatherData.NewMeasures -= DisplayStatisticReport;
        }
    }
}
