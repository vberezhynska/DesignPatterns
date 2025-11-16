namespace FactoryMethod
{
    internal static class ClientCode
    {
        public static void Execute(Creator abstractCreator)
        { 
            Console.WriteLine(abstractCreator.SomeOperation());
        }
    }
}
