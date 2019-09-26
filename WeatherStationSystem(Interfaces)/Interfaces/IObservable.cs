namespace WeatherStationSystem_Interfaces_.Interfaces
{
    /// <summary>
    /// IObservable interface
    /// </summary>
    public interface IObservable
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void Notify();
    }
}
