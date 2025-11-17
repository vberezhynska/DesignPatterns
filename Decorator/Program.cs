using Decorator.Encription;

Console.WriteLine("Decorator Pattern Example. Type string to be decorated:");
var initiaString = Console.ReadLine() ?? "Hello, World!";
Console.WriteLine($"Initial string: {initiaString}");

IDataSource dataSource = new FileDataSource("data.txt");

dataSource = new AdditionalCharEncriptionDecorator(new ReverseEncriptionDecorator(dataSource));
dataSource.WriteData(initiaString);
Console.WriteLine($"Fully decorated string: {dataSource.ReadData()}");