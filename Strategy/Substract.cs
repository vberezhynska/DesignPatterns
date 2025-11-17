
namespace Strategy
{
    internal class Substract : IStrategy
    {
        public decimal Execute(decimal x, decimal y) => x - y;
    }
}
