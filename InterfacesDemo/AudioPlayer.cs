namespace InterfacesDemo;

public class AudioPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Playing Audio");
    }

    public void Stop()
    {
        Console.WriteLine("Audio Stopped");
    }

    public void Pause()
    {
        Console.WriteLine("Audio Paused");
    }
}