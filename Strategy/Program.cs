// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Behaviour patter 'Strategy'");
var requiredStrategy = Console.ReadLine();
IStrategy strategy = requiredStrategy switch
{
    "+" or "add" => new Add(),
    "-" or "subtract" => new Substract(),
    "*" or "multiply" => new Multiply(),
    _ => throw new ArgumentOutOfRangeException(nameof(requiredStrategy), "Unknown strategy")
};

var context = new Context(strategy);
Console.WriteLine($"Result of {requiredStrategy} for 10 and 5 is {context.ExecuteStrategy(10, 5)}");