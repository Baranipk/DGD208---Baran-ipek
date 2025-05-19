namespace FinalProject;

public class Dog : IPet
{
    public PetType Type { get; set; }
    public string PetName { get; set; } = "";
    public int SleepStat { get; set; }
    public int FunStat { get; set; }
    public int HungerStat { get; set; }
    public void GetHunger()
    {
        
    }

    public void ReduceFun()
    {
        
    }

    public void GetSleep()
    {
        
    }
}