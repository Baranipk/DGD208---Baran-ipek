namespace FinalProject;

public class Game
{
    private bool _isRunning;
    
    public async Task GameLoop()
    {
        // Initialize the game
        Initialize();
        
        // Main game loop
        _isRunning = true;
        while (_isRunning)
        {
            // Display menu and get player input
            string userChoice = GetUserInput();
            
            // Process the player's choice
            await ProcessUserChoice(userChoice);
        }
        
        Console.WriteLine("Thanks for playing!\n" +
                          "  /^ ^\\\n / 0 0 \\\n V\\ Y /V\n  / - \\\n /    |\nV__) ||" +
                          "");
    }
    
    private void Initialize()
    {
        
    }
    
    private string GetUserInput()
    {
        while (true)
        {
            Console.WriteLine("Select a Choise. ");
            Console.WriteLine("1.Devoloper's Info");
            Console.WriteLine("2.Pets");
            Console.WriteLine("3.Inventory");
            Console.WriteLine("4.Adopt Pet");
            Console.WriteLine("5.Quit");
            
            string userInput = Console.ReadLine();
            if (userInput == "1".ToLower().Trim())
            {
                return "1";
            } 
            else if (userInput == "2".ToLower().Trim())
            {
                return "2";
            }
            else if (userInput == "3".ToLower().Trim())
            {
                return "3";
            }else if (userInput == "4".ToLower().Trim())
            {
                return "4";
            }
            else if (userInput == "5".ToLower().Trim())
            {
                return "5";
            }
        }
        
        
    }
    
    private async Task ProcessUserChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine("------ BARAN İPEK : 225040097 ------");
                break;
            case "2":
                Console.WriteLine("Pets");
                break;
            case "3":
                Console.WriteLine("Inventory");
                break;
            case "4":
                Console.WriteLine("Adopt Pet");
                break;
            case "5":
                _isRunning = false; break;
        }

        // Use this to process any choice user makes
        // Set _isRunning = false to exit the game
    }
}