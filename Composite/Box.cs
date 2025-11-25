namespace Composite
{
    internal class Box : IPrice
    {
        private readonly decimal _price;
        public Box(decimal price) => _price = price;
        public decimal GetPrice() => _price;
    }
}
