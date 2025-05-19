namespace GamePrograming1;

public abstract class Vehicle 
{
    public float Fuel { get; protected set; }

    public void UseFuel(float fuel)
    {
        Fuel = Fuel - fuel < 0f ? 0f : Fuel - fuel;
    }
}