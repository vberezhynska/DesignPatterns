namespace Iterator
{
    internal class RandomIterator : Iterator, IIterator
    {
        private List<int> unUsedIndexes;
        private readonly Random _random = new Random();

        public RandomIterator(List<AudioFile> audioFiles) : base(audioFiles)
        {
            unUsedIndexes = Enumerable.Range(0, audios.Length).ToList();
        }

        public bool HasNext()
        {
            if (unUsedIndexes.Count == 0 && playInCircle)
            { 
                unUsedIndexes = Enumerable.Range(0, audios.Length).ToList();
                Console.WriteLine("Restarting random playback.");
            }

            var unUsedIndex = _random.Next(0, unUsedIndexes.Count);
            currentIndex = unUsedIndexes[unUsedIndex];
            unUsedIndexes.RemoveAt(unUsedIndex);

            return unUsedIndexes.Count > 1;
        }

        public AudioFile Next() => audios[currentIndex];
    }
}
