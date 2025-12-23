namespace InterfacesDemo;

public class VideoPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Video is Playing");
    }

    public void Stop()
    {
        Console.WriteLine("Video is Stopped");
    }

    public void Pause()
    {
        Console.WriteLine("Video is Paused");
    }
}