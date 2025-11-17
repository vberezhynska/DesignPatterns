namespace Decorator.Encription
{
    internal class FileDataSource : IDataSource
    {
        private readonly string _fileName;
        public FileDataSource(string fileName)
        {
            _fileName = fileName;
        }
        public string ReadData()
        {
            try
            {
                Console.WriteLine($"Reading data from file: {_fileName}");
                return File.ReadAllText(_fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading to the file. {ex.Message}\n{ex.StackTrace}");
            }
            return string.Empty;
        }

        public void WriteData(string data)
        {
            try
            {
                Console.WriteLine($"Writing data to file: {_fileName}");
                File.WriteAllText(_fileName, data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file. {ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}
