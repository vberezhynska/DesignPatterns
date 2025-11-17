namespace Decorator.Encription
{
    internal abstract class DataSourceDecorator : IDataSource
    {
        protected readonly IDataSource _wrappee;
        protected DataSourceDecorator(IDataSource dataSource)
        {
            _wrappee = dataSource;
        }

        // No additional behavior should be in virtual methods, simply delegates to the wrappee.
        // Other decorators may override this method to add behavior
        public virtual string ReadData()
        {
            return _wrappee.ReadData();
        }

        public virtual void WriteData(string data)
        {
            _wrappee.WriteData(data);
        }
    }
}
