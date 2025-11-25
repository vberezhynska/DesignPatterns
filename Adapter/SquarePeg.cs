namespace Adapter
{
    internal class SquarePeg
    {
        readonly decimal _width;
        public SquarePeg(decimal width)
        {
            _width = width;
        }
        public decimal GetWidth()
        {
            return _width;
        }
    }
}
