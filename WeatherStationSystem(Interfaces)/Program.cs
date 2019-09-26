using WeatherStationSystem_Interfaces_.DisplayElements;

namespace WeatherStationSystem_Interfaces_
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            var currentConditionsReport = new CurrentConditionsReport(weatherData);
            StatisticReport statisticReport = new StatisticReport(weatherData);
            weatherData.SimulateNewMeasurmentData(8, 670, 60);
            weatherData.SimulateNewMeasurmentData(12, 650, 65);
            weatherData.SimulateNewMeasurmentData(10, 600, 68.5);
        }
    }
}
