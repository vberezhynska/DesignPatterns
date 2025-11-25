namespace Iterator
{
    internal class AudioFile
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public AudioFile(string name, string artist)
        {
            Name = name;
            Artist = artist;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Artinst: {Artist}";
        }
    }
}
