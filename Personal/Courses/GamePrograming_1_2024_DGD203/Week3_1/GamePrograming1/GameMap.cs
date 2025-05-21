
namespace GamePrograming1;

public class GameMap
{
    #region Variables

    private const int DefaultWidth = 8;
    private const int DefaultHeight = 8;
    
    private readonly int _width;
    private readonly int _height;
    private Vector2Int _playerPosition;
    private readonly Location[,] _mapLocations;

    #endregion

    #region Internal Classes
    
    public class Location
    {
        public string Description { get; set; }

        public bool IsAccessible { get; set; }

        public Dictionary<string, string> InteractiveObjects { get; set; }

        public Location(string description = "", bool isAccessible = true)
        {
            Description = description;
            IsAccessible = isAccessible;
            InteractiveObjects = new Dictionary<string, string>();
        }
    }
    #endregion

    #region CONSTRUCTOR
    public GameMap(int width, int height, Vector2Int startPosition)
    {
        CheckInputDimensions(ref width, ref height);
       
        _width = width;
        _height = height;
        _mapLocations = new Location[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                _mapLocations[x, y] = new Location();
            }
        }

        if (IsValidPosition(startPosition))
        {
            _playerPosition = startPosition;
        }
        else
        {
            _playerPosition = new Vector2Int();
        }
    }    
    #endregion
    
    #region Methods

    public void CheckInputDimensions(ref int width, ref int height)
    {
        if (width <= 0 || height <= 0)
        {
            width = DefaultWidth;
            height = DefaultHeight;
        }
    }
    
    public Vector2Int GetPlayerPosition() => _playerPosition;

    public bool MovePlayer(Direction direction)
        {
            var newPosition = CalculateNewPosition(direction);

            if (IsValidPosition(newPosition) && _mapLocations[newPosition.X, newPosition.Y].IsAccessible)
            {
                _playerPosition = newPosition;
                return true;
            }
            return false;
        }

    private Vector2Int CalculateNewPosition(Direction direction)
    {
        Vector2Int newPosition = new Vector2Int();
        newPosition = _playerPosition;
        switch (direction)
        {
            case Direction.North:
                newPosition.Y += 1;
                break;
            case Direction.South:
                newPosition.Y -= 1;
                break;
            case Direction.West:
                newPosition.X -= 1;
                break;
            case Direction.East:
                newPosition.X += 1;
                break;
            default:
                Console.WriteLine("Invalid direction!");
                break;
        }
            return newPosition;
        }

    private bool IsValidPosition(Vector2Int position)
        {
            return position.X >= 0 && position.Y < _width &&
                   position.Y >= 0 && position.X < _height;
        }

    public Location GetCurrentLocation()
        {
            return _mapLocations[_playerPosition.X, _playerPosition.Y];
        }

    public void SetLocationDescription(Vector2Int position, string description)
        {
            if (IsValidPosition(position))
            {
                _mapLocations[position.X, position.Y].Description = description;
            }
        }

    public void SetLocationAccessibility(Vector2Int position, bool isAccessible)
        {
            if (IsValidPosition(position))
            {
                _mapLocations[position.X, position.Y].IsAccessible = isAccessible;
            }
        }

    public void AddInteractiveObject(Vector2Int position, string objectName, string description)
        {
            if (IsValidPosition(position))
            {
                _mapLocations[position.X, position.Y].InteractiveObjects[objectName] = description;
            }
        }
        
    #endregion
}

public enum Direction
{
    East,
    North,
    West,
    South,
    NorthEast,
    NorthWest,
    SouthEast,
    SouthWest,
    Up,
    Down,
    Inside,
    Outside,
    Right,
    Forward,
    Left,
    Back
}