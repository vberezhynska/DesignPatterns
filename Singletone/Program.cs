// See https://aka.ms/new-console-template for more information
using Singletone;

var cache = MemoryCache.GetInstance();
Console.WriteLine(cache.GetInstanceNumber());

var anotherInstanceOfCache = MemoryCache.GetInstance();
Console.WriteLine(anotherInstanceOfCache.GetInstanceNumber());

int size = 8;
Task[] tasks = new Task[size];
for (int i = 0; i < size; i++)
{
    tasks[i] = Task.Run(() =>
    {
        var currencyCache = MemoryCache.GetInstance();
        currencyCache.GetInstanceNumber();
    });
}
Task.WaitAll(tasks);