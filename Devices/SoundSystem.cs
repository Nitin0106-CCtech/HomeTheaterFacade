namespace HomeTheaterFacade.Devices;

public class SoundSystem
{
    public void On()
    {
        Console.WriteLine("Sound System ON");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"Volume set to {level}");
    }

    public void Off()
    {
        Console.WriteLine("Sound System OFF");
    }
}
