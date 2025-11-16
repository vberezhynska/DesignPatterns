namespace FactoryMethod
{
    internal class ConcreteCreatorTwo : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreateProductTwo();
        }
    }
}
