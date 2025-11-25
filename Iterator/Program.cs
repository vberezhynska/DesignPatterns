using Iterator;

Console.WriteLine("Hello, Iterator!");

var audioFiles = new List<AudioFile>() { 
    new ("Song 1", "Artist A"),
    new ("Song 2", "Artist B"),
    new ("Song 3", "Artist C"),
    new ("Song 4", "Artist D"),
    new ("Song 5", "Artist E"),
};

var player = new DesktopPlayer();
var iterator = new LineIterator(audioFiles);
var app = new Application(player, iterator);

Console.WriteLine("Do you want to play songs in circle? Type: y/n");
var input = Console.ReadLine();
if (input != null && input.ToLower() == "y")
{
    iterator.SetPlayInCircle();
}

Console.WriteLine("Press R to Run, B to stop");
Task? playTask = null;

while (true)
{
    var key = Console.ReadKey(true);
    if (key.Key == ConsoleKey.R)
    {
        if (playTask == null || playTask.IsCompleted)
        {
            playTask = Task.Run(() => app.Start());
        }
        else
        {
            Console.WriteLine("Already playing.");
        }
    }
    if (key.Key == ConsoleKey.B)
    {
        app.Stop();
    }
}