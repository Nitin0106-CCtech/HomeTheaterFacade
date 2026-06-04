using HomeTheaterFacade.Devices;
using HomeTheaterFacade.Facade;

DVDPlayer dvd = new();
Projector projector = new();
SoundSystem sound = new();
Lights lights = new();
Screen screen = new();

var theater =
    new HomeTheaterFacade.Facade.HomeTheaterFacade(
        dvd,
        projector,
        sound,
        lights,
        screen);

theater.WatchMovie("Avengers: Endgame");

Console.WriteLine("\nPress Enter to stop movie...");
Console.ReadLine();

theater.EndMovie();
