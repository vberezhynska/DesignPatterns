namespace Observer
{
    internal class SmartfoneDisplay : IObserver
    {
        public void Update(decimal temperature)
        {
            Console.WriteLine($"Smartfone Display: Temperature updated to {temperature}°C");
        }
    }
}
