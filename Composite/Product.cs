namespace Composite
{
    internal class Product : IPrice
    {
        private readonly decimal _price;
        public Product(decimal price) => _price = price;
        public decimal GetPrice() => _price;
    }
}