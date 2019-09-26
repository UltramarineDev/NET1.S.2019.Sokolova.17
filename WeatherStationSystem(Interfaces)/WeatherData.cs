using System.Collections.Generic;
using WeatherStationSystem_Interfaces_.Interfaces;

namespace WeatherStationSystem_Interfaces_
{
    /// <summary>
    /// WeatherData class
    /// </summary>
    /// <seealso cref="WeatherStationSystem_Interfaces_.Interfaces.IObservable" />
    public class WeatherData : IObservable
    {
        private List<IObserver> observers;

        public double temperature;
        public double pressure;
        public double humidity;

        /// <summary>
        /// Simulates the new measurment data.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <param name="humidity">The humidity.</param>
        /// <param name="pressure">The pressure.</param>
        public void SimulateNewMeasurmentData(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Notify();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherData"/> class.
        /// </summary>
        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(temperature, humidity, pressure);
            }
        }

        /// <summary>
        /// Registers the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Unregisters the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
