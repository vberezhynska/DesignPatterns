namespace Decorator.Encription
{
    internal interface IDataSource
    {
        public void WriteData(string data);
        public string ReadData();
    }
}
