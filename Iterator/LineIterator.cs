namespace Iterator
{
    internal class LineIterator : Iterator, IIterator
    {
        public LineIterator(List<AudioFile> audioItems) : base(audioItems) { }
        public bool HasNext()
        {
            currentIndex++;
            if (currentIndex < audios.Length)
                return true;

            currentIndex = -1;
            if (playInCircle)
                return HasNext();

            return false;
        }

        public AudioFile Next() => audios[currentIndex];
    }
}
