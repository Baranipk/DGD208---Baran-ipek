namespace FinalProject;

public class Pet : IPet
{
    public PetType Type { get; set; } 
    
    public string PetName { get; set; }
    
    public int SleepStat { get; set; } = 50;
    
    public int FunStat { get; set; } = 50;
    
    public int HungerStat { get; set; } = 50;

    private bool _isAlive = false;


    public Pet(PetType type, string petName)
    {
        _isAlive = true;
        Type = type;
        PetName = petName;
        
    }
    
    public void GetHunger()
    {
        if (_isAlive)
        {
            if (HungerStat > 0)
            {
                HungerStat--;
            }
            else
            {
                PetDie("açlık");
            }
            
        }
    }

    public void ReduceFun()
    {
        if (_isAlive)
        {
            if (FunStat > 0)
            {
                FunStat--;
            }
            else
            {
                PetDie("mutsuzluk");
            }
            
        }
    }

    public void GetSleep()
    {
        if (_isAlive)
        {
            if (SleepStat > 0)
            {
                SleepStat--;
            }
            else
            {
                PetDie("uykusuzluk");
            }
            
        }
    }

    public void PetDie(string deadFrom)
    {
        Console.WriteLine($"{PetName}, {deadFrom} Yüzünden Öldü! ");
        _isAlive = false;
    }
}