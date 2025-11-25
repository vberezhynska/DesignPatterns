namespace Iterator
{
    abstract class Iterator
    {
        protected AudioFile[] audios;
        protected int currentIndex = -1;
        protected bool playInCircle = false;

        protected Iterator(List<AudioFile> audioFiles) 
        {
            audios = audioFiles.ToArray();
        }

        public void SetPlayInCircle() => playInCircle = true;
        public void ResetPlayInCircle() => playInCircle = false;

    }
}
