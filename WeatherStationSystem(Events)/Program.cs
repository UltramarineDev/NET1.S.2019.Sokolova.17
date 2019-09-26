using WeatherStationSystem_Events_.DisplayElements;

namespace WeatherStationSystem_Events_
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            var currentConditionsReport = new CurrentConditionsReport(weatherData);
            var statisticReport = new StatisticReport(weatherData);
            weatherData.SimulateNewMeasurmentData(8, 500, 50);
            weatherData.SimulateNewMeasurmentData(10, 550, 55);

            statisticReport.Unregister(weatherData);
            weatherData.SimulateNewMeasurmentData(13, 600, 60);
        }
    }
}
