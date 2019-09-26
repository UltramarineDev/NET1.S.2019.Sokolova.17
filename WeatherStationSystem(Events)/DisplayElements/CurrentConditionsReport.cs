using System;

namespace WeatherStationSystem_Events_.DisplayElements
{
    public class CurrentConditionsReport
    {
        public CurrentConditionsReport(WeatherData weatherData)
        {
            weatherData.NewMeasures += DisplayCurrentConditions;
        }

        private void DisplayCurrentConditions(object sender, WeatherMeasuresEventArgs e)
        {
            var printString = $"Current conditions:\nTemperature is {e.Temperature} degrees,\nHumidity is {e.Humidity}%\nPressure is {e.Pressure} ";
            Console.WriteLine(printString);
        }

        public void Unregister(WeatherData weatherData)
        {
            weatherData.NewMeasures -= DisplayCurrentConditions;
        }
    }
}
