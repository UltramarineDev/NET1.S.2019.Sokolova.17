using System;
namespace WeatherStationSystem_Events_
{
    public sealed class WeatherMeasuresEventArgs : EventArgs
    {
        private readonly double temperature;
        private readonly double pressure;
        private readonly double humidity;

        public WeatherMeasuresEventArgs(double temperature, double pressure, double humidity)
        {
            this.temperature = temperature;
            this.pressure = pressure;
            this.humidity = humidity;
        }

        public double Temperature { get { return temperature; } }
        public double Pressure { get { return pressure; } }
        public double Humidity { get { return humidity; } }
    }
}
