namespace GamePrograming1;
public class Game
{
    #region REFERENCES
    
    private Player _player;
    private GameMap _map;
    private Commands _commands;
    private Inventory _inventory;
        
    #endregion
    
    #region Variables
    
    #region Constant Variables
    
    private const int MapWidth = 5;
    private const int MapHeight = 5;
    
    private const string NewCommandSeparator = "-------------------------";
    
    private static readonly Vector2Int DefaultStartingCoordinates = new Vector2Int {X = 0, Y = 0};
    
    #endregion
    
    #region Game State Variables
    //GameState var.
    
    private bool _isRunning;
    
     #endregion
    
    #region Command Variables
     //Command var.
    
    private string _currentCommand;
    
    #endregion
    
    #endregion
    
    #region Constructor
    
    public Game()
    {
        GenerateMap();
        GenerateInventory();
        GenerateStartingInstances();
        
    }
    #endregion
    
    #region Methods
    
    #region Starting Methods
    public void StartGame()
    {
        GenerateMap();
        GetPlayerName();
        StartGameLoop();
        
        GameLoop();
    }

    private void GenerateStartingInstances()
    {
        _commands = new Commands(this, _map);
        _player = new Player();
    }

    private void GenerateMap()
    {
        _map = new GameMap(MapWidth, MapHeight,DefaultStartingCoordinates);
    }

    private void GenerateInventory()
    {
        _inventory = new Inventory(this);
    }

    private void GetPlayerName()
    {
        Console.Write("Game Started. Please give your name: ");
        
             string playerName = Console.ReadLine();
             if (playerName == "" || playerName == null)
             {
                 Console.WriteLine("There is no name here! You are dead to me");
                 playerName = "Dead2Me";
             }
             
             _player.Initialize(playerName);
        
             Console.WriteLine($"Welcome, {_player.Name}  to this game ");
    }
    
    #endregion

    #region GameloopMethods

    private void StartGameLoop()
    {
        _isRunning = true;
    }

    private void GameLoop()
    {
        while (_isRunning)
        {
            RecieveCommand();
            ApplyCommand();
        }
    }

    private void RecieveCommand()
    {
        Console.WriteLine(NewCommandSeparator);
        Console.Write("What do you want to do?: ");
        _currentCommand = Console.ReadLine();
    }

    private void ApplyCommand()
    {
        _commands.ExecuteCommand(_currentCommand);
    }
    

    private string CurrentLocationDescription()
    {
        GameMap.Location currentLocation = _map.GetCurrentLocation();
        return currentLocation.Description;
    }

    public void GiveExitCommand()
    {
        _isRunning = false;
    }
    
    #endregion
    
    #endregion
}
