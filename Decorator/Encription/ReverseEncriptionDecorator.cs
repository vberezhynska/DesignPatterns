namespace Decorator.Encription
{
    internal class ReverseEncriptionDecorator : DataSourceDecorator

    {
        public ReverseEncriptionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override string ReadData()
        {
            string data = base.ReadData();
            Decrypt(ref data);
            Console.WriteLine($"ReverseEncriptionDecorator reads: {data}");
            return data;
        }

        public override void WriteData(string data)
        {
            Encrypt(ref data);
            Console.WriteLine($"ReverseEncriptionDecorator writes: {data}");
            base.WriteData(data);
        }

        private static void Encrypt(ref string data)
        {
            if (string.IsNullOrEmpty(data))
                return;
            char[] array = data.ToCharArray();
            Array.Reverse(array);
            data = new string(array);
        }

        private static void Decrypt(ref string data)
        {
            if (string.IsNullOrEmpty(data))
                return;
            char[] array = data.ToCharArray();
            Array.Reverse(array);
           data = new string(array);
        }
    }
}
