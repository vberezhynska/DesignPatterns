using System.Text;

namespace Decorator.Encription
{
    internal class AdditionalCharEncriptionDecorator : DataSourceDecorator
    {
        public AdditionalCharEncriptionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override string ReadData()
        {
            string data = base.ReadData();
            Decrypt(ref data);
            Console.WriteLine($"AdditionalCharEncriptionDecorator writes: {data}");
            return data;
        }

        public override void WriteData(string data)
        {
            Encrypt(ref data);
            Console.WriteLine($"AdditionalCharEncriptionDecorator writes: {data}");
            base.WriteData(data);
        }

        private static void Decrypt(ref string data)
        {
            if (string.IsNullOrEmpty(data))
                return;

            StringBuilder result = new StringBuilder();

            foreach (char c in data)
            {
                // Shift to previous character
                char nextChar = (char)(c - 1);
                result.Append(nextChar);
            }

            data = result.ToString();
        }

        private static void Encrypt(ref string data)
        {
            if (string.IsNullOrEmpty(data))
                return;

            StringBuilder result = new StringBuilder();

            foreach (char c in data)
            {
                // Shift to next character
                char nextChar = (char)(c + 1);
                result.Append(nextChar);
            }

            data = result.ToString();
        }
    }
}
