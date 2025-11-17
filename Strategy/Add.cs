namespace Strategy
{
    internal class Add : IStrategy
    {
        public decimal Execute(decimal x, decimal y) => x + y;
    }
}
