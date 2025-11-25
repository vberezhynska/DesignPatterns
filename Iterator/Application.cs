namespace Iterator
{
    internal class Application
    {
        private bool _isRunning = false;
        private AudioFile _currentAudioFile;
        public IPlayer Player;
        public IIterator Iterator;
        public Application(IPlayer player, IIterator iterator)
        {
            Player = player;
            Iterator = iterator;
        }

        public void Start() 
        {
            _isRunning = true;
            while (_isRunning && Iterator.HasNext()) 
            {
                _currentAudioFile = Iterator.Next();
                Player.Play(_currentAudioFile);
                Thread.Sleep(1000);
            }
        }

        public void Stop() 
        {
            _isRunning = false;
            if (_currentAudioFile is null)
            {
                Console.WriteLine($"No audion file is currently playing."); 
                return;
            }

            Player.Stop(_currentAudioFile);
        }
    }
}
