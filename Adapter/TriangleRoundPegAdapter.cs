namespace Adapter
{
    internal class TriangleRoundPegAdapter : IRoundPeg
    {
        private TrianglePeg _triangle;
        public TriangleRoundPegAdapter(TrianglePeg triangle)
        {
            _triangle = triangle;
        }

        public decimal GetRadius()
        {
            return (decimal)(_triangle.A + _triangle.B + _triangle.C) / 2;
        }
    }
}
