namespace Observer
{
    internal interface IPublisher
    {
        public void Notify();
        public void Subscribe(IObserver observer);
        public void Unsubscribe(IObserver observer);
    }
}
