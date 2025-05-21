namespace GamePrograming1;

public class Map
{
    private Vector2Int _mapSize;
    
    
    public Vector2Int CurrentCoordinates { get;private set; }
    
    public Map(int width, int height)
    {
        _mapSize.X = width;
        _mapSize.Y = height;
        
        Console.WriteLine($"Created a map with width: {_mapSize.X} and height: {_mapSize.Y}");
    }

    public void SetCoordinates()
    {
        CurrentCoordinates = new Vector2Int{X= 0, Y= 0};
    }
    
    public void SetCoordinates(int x, int y)
    {

        CurrentCoordinates = new Vector2Int {X = x, Y = y };
        
        Console.WriteLine($"Starting coordinates is {CurrentCoordinates.X} , {CurrentCoordinates.Y}");
    }
}

