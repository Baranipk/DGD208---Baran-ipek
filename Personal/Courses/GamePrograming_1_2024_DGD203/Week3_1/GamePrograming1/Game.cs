using GamePrograming1.Engines;

namespace GamePrograming1;

public class Game
{
    #region Variables
    
    #region Constant Variables
    
    private const int MapWidth = 5;
    private const int MapHeight = 5;
    
    private const string NewCommandSeparator = "-------------------------";
    
    #endregion

    private static readonly Vector2Int DefaultStartingCoordinates = new Vector2Int {X = 0, Y = 0};
    
    private Player _player;
    private GameMap _map;

    //GameState var.
    
    private bool _isRunning;
    
    //Command var.
    private string _CurrentCommand;
    
    #endregion
    
    #region Constructor
    
    public Game()
    {
        _player = new Player();
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

    private void GenerateMap()
    {
        _map = new GameMap(MapWidth, MapHeight,DefaultStartingCoordinates);
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
            CheckIfGameOver();
        }
    }

    private void RecieveCommand()
    {
        Console.WriteLine(NewCommandSeparator);
        Console.Write("What do you want to do?: ");
        _CurrentCommand = Console.ReadLine();
    }

    private void ApplyCommand()
    {
        if (ExitCommandGiven())
        {
            _isRunning = false;
            return;
        }
        
        ProcessMapCommand();
        ProcessInventoryCommand();
    }

    private void CheckIfGameOver()
    {
        
    }

    private string CurrentLocationDescription()
    {
        GameMap.Location currentLocation = _map.GetCurrentLocation();
        return currentLocation.Description;
    }

    private bool ExitCommandGiven()
    {
        return _CurrentCommand.ToLower() == "exit";
    }

    private void ProcessMapCommand()
    {
        _map.MovePlayer(_CurrentCommand);
        Vector2Int playerPosition = _map.GetPlayerPosition();
        Console.Write($"Your current position is {playerPosition.X},{playerPosition.Y}");
        Console.WriteLine(CurrentLocationDescription());
    }

    private void ProcessInventoryCommand()
    {
        
    }
    
    #endregion
    
    #endregion
}