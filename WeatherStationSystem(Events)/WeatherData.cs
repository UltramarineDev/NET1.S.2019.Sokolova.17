using System;

namespace WeatherStationSystem_Events_
{
    public class WeatherData
    {
        public event EventHandler<WeatherMeasuresEventArgs> NewMeasures = delegate { };

        protected virtual void OnNewMeasures(object sender, WeatherMeasuresEventArgs e)
        {
            NewMeasures?.Invoke(this, e);
        }

        public void SimulateNewMeasurmentData(double temperature, double pressure, double humidity)
        {
            OnNewMeasures(this, new WeatherMeasuresEventArgs(temperature, pressure, humidity));
        }
    }
}
