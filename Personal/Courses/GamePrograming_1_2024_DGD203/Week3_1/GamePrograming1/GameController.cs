using GamePrograming1.Engines;

namespace GamePrograming1;

public class GameController
{
    private const int MapWidth = 5;
    private const int MapHeight = 5;

    private static readonly Vector2Int DefaultStartingCoordinates = new Vector2Int {X = 0, Y = 0};
    
    private Player _player;
    private Map _map;
    public GameController()
    {
        
        _player = new Player();
    }
    public void StartGame()
    {
        GenerateMap();
        GetPlayerName();
    }

    private void GenerateMap()
    {
        _map = new Map(MapWidth, MapHeight);
        _map.SetCoordinates(0,0);
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
}