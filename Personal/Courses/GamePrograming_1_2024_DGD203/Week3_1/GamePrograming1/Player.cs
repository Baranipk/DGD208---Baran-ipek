namespace GamePrograming1;

public class Player
{
    public string Name { get; private set; }
    

        

    public Player(string name = "jhon doe")
    {
        Name = name;
        
    }

    public void Initialize(string name)
    {
        Name = name;
        
    }

    
     
}