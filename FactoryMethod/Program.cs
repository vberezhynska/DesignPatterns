// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");

for (int i = 0; i < 2; i++)
{
    Creator creator = i % 2 == 0 ? new ConcreteCreatorOne() : new ConcreteCreatorTwo();
    ClientCode.Execute(creator);
}
