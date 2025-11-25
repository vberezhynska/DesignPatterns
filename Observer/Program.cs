// See https://aka.ms/new-console-template for more information
using Observer;

Console.WriteLine("Hello, Observer!");

List<decimal> temperatures = new List<decimal> { -2.3m, 6.7m, 0m, 27.1m, 35m };
var oldDevice  = new OldWeatherDevice();
var smartfoneDisplay = new SmartfoneDisplay();
var weatherStation = new WeatherStation();
weatherStation.Subscribe(oldDevice);
weatherStation.Subscribe(smartfoneDisplay);

foreach(var temp in temperatures)
{
    weatherStation.SetTemperature(temp);
    Thread.Sleep(1000);
}