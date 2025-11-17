namespace Strategy
{
    internal class Context
    {
        private readonly IStrategy _strategy;
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal ExecuteStrategy(decimal x, decimal y)
        {
            return _strategy.Execute(x, y);
        }
    }
}
