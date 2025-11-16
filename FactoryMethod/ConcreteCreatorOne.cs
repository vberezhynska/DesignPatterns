namespace FactoryMethod
{
    internal class ConcreteCreatorOne : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreateProductOne();
        }
    }
}
