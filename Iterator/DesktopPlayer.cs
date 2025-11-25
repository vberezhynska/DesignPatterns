namespace Iterator
{
    internal class DesktopPlayer : IPlayer
    {
        public void Play(AudioFile audioFile)
        {
            Console.WriteLine($"Playing from Desktop {audioFile.ToString()}");
        }
    
        public void Stop(AudioFile audioFile)
        {
            Console.WriteLine($"Stoped from Desktop {audioFile.ToString()}");
        }
    }
}