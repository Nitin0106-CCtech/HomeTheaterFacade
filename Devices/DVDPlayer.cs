namespace HomeTheaterFacade.Devices;

public class DVDPlayer
{
    public void On()
    {
        Console.WriteLine("DVD Player ON");
    }

    public void PlayMovie(string movie)
    {
        Console.WriteLine($"Playing movie: {movie}");
    }

    public void Off()
    {
        Console.WriteLine("DVD Player OFF");
    }
}
