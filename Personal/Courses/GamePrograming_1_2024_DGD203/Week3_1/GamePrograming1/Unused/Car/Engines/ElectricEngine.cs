namespace GamePrograming1.Engines;

public class ElectricEngine : Engine
{
    public override void Start()
    {
        base.Start();
        CheckBatteryStatus();
        Console.WriteLine("The engine does not make any sound");
    }

    private void CheckBatteryStatus()
    {
        Console.WriteLine("The battery is fine");
    }
}