namespace WeatherStationSystem_Interfaces_.Interfaces
{
    /// <summary>
    /// IObserver interface
    /// </summary>
    public interface IObserver
    {
       void Update(double temperature, double humidity, double pressure);
    }
}
