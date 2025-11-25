namespace Adapter
{
    internal class SquareRoundPegAdapter : IRoundPeg
    {
        private readonly SquarePeg _peg;
        public SquareRoundPegAdapter(SquarePeg peg)
        {
            _peg = peg;
        }

        public decimal GetRadius()
        {
            var k = (decimal)(Math.Sqrt(2) / 2);
            return _peg.GetWidth() * k;
        }
    }
}
