
namespace Adapter
{
    internal class RoundHole
    {
        readonly decimal _radius;
        public RoundHole(decimal radius)
        {
            _radius = radius;
        }
        public decimal GetRadius()
        {
            return _radius;
        }

        public bool Fits(IRoundPeg rPeg)
        {
            return rPeg.GetRadius() <= _radius;
        }

        public string FitsSt(IRoundPeg rPeg)
        {
            return Fits(rPeg) ? "fits" : "does not fit";
        }
    }
}
