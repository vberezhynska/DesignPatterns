namespace Composite
{
    internal class ComposedProduct : IPrice
    {
        private readonly List<IPrice> _items = new List<IPrice>();
        
        public void AddItem(IPrice item)
        {
            _items.Add(item);
        }

        public void RemoveItem(IPrice item)
        {
            _items.Remove(item);
        }

        public decimal GetPrice()
        {
            return _items?.Sum(item => item.GetPrice()) ?? 0;
        }
    }
}
