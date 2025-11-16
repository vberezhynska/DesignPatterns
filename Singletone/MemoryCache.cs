namespace Singletone
{
    public sealed class MemoryCache
    {
        private static int count = 0; 
        private static MemoryCache _memoryCache;
        private static object _cacheLock = new object();
        private MemoryCache()
        {
            Console.WriteLine($"Create instance {++count}");
        }
        public static MemoryCache GetInstance()
        {
            if (_memoryCache == null)
            {
                lock (_cacheLock)
                {
                    if (_memoryCache == null)
                    {
                        return _memoryCache = new MemoryCache();
                    }
                }
            }
            return _memoryCache;
        }

        public int GetInstanceNumber()
        {
            return count;
        }
    }
}
