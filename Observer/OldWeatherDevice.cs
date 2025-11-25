namespace Observer
{
    internal class OldWeatherDevice : IObserver
    {
        public void Update(decimal temperature)
        {
            Console.WriteLine($"Old Weather Device: Temperature updated to {temperature}°C");
            if (temperature > 30)
            {
                Console.WriteLine("Old Weather Device: It's getting hot!");
            }

            if (temperature < 0)
            {
                Console.WriteLine("Old Weather Device: It's freezing cold!");
            }
        }
    }
}
