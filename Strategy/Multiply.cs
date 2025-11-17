namespace Strategy
{
    internal class Multiply : IStrategy
    {
        public decimal Execute(decimal x, decimal y) => x * y;
    }
}
