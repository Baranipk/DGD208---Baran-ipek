namespace GamePrograming1;

public class Commands
{

    #region REFERENCES
    
    private Game _game;
    private GameMap _map;

    #endregion
    
    #region CONSTRUCTORS
    public Commands(Game game, GameMap map)
    {
        _game = game;
        _map = map;
    }
    
    #endregion
    
    #region METHODS
    public void ExecuteCommand(string command)
    {
        switch (command.ToLower())
        {
            //Map Commands
            case "east":
                MoveCommand(Direction.East);
                break;
            case"north":
                MoveCommand(Direction.North);
                break;
            case "west":
                MoveCommand(Direction.West);
                break;
            case "south":
                MoveCommand(Direction.South);
                break;
            
            
            //Inventory Commands
            
            //Multiple Choices
            
            // Game Commands
            
            case "exit":
                _game.GiveExitCommand();
                break;
            
            //default
            default:
                Console.WriteLine("Invalid command");
                break;
            
        }
    }

    #region MAP Commands
    
    private void MoveCommand(Direction direction)
    {
        _map.MovePlayer(direction);
        Vector2Int playerPosition = _map.GetPlayerPosition();
        Console.Write($"Your current position is {playerPosition.X},{playerPosition.Y}");
        Console.WriteLine(CurrentLocationDescription());
    }
    private string CurrentLocationDescription()
    {
        GameMap.Location currentLocation = _map.GetCurrentLocation();
        return currentLocation.Description;
    }
    
    #endregion
    
    #endregion
}