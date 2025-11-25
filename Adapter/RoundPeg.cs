namespace Adapter
{
    internal class RoundPeg : IRoundPeg
    {
        readonly decimal _radius;
        public RoundPeg(decimal radius)
        {
            _radius = radius;
        }
        public decimal GetRadius()
        {
            return _radius;
        }
    }
}
