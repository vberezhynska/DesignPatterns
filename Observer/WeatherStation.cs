namespace Observer
{
    //publisher
    internal class WeatherStation : IPublisher
    {
        List<IObserver> _observers = new List<IObserver>();
        private decimal _temperature;
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void SetTemperature(decimal temperature)
        {
            _temperature = temperature;
            Console.WriteLine($"\nWeather Station: New temperature is {_temperature}°C");
            Notify();
        }
    }
}
