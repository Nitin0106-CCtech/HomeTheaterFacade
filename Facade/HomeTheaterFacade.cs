using HomeTheaterFacade.Devices;

namespace HomeTheaterFacade.Facade;

public class HomeTheaterFacade
{
    private readonly DVDPlayer _dvdPlayer;
    private readonly Projector _projector;
    private readonly SoundSystem _soundSystem;
    private readonly Lights _lights;
    private readonly Screen _screen;

    public HomeTheaterFacade(
        DVDPlayer dvdPlayer,
        Projector projector,
        SoundSystem soundSystem,
        Lights lights,
        Screen screen)
    {
        _dvdPlayer = dvdPlayer;
        _projector = projector;
        _soundSystem = soundSystem;
        _lights = lights;
        _screen = screen;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("\nStarting Movie Mode...\n");

        _lights.Dim();
        _screen.Down();
        _projector.On();
        _soundSystem.On();
        _soundSystem.SetVolume(15);
        _dvdPlayer.On();
        _dvdPlayer.PlayMovie(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("\nShutting Down Theater...\n");

        _dvdPlayer.Off();
        _soundSystem.Off();
        _projector.Off();
        _screen.Up();
        _lights.On();
    }
}
