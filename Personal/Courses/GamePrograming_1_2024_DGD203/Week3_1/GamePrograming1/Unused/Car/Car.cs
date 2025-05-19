namespace GamePrograming1;

public class Car : Vehicle
{
    private IEngine _engine;
    public Car(float fuelAmount,IEngine engine)
    {
        base.Fuel = fuelAmount;
        _engine = engine;
    }
    
    public void StartCar()
    {
        _engine.Start();
    }
}