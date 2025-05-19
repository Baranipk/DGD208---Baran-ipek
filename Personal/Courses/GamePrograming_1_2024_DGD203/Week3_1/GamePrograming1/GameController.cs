using GamePrograming1.Engines;

namespace GamePrograming1;

public class GameController
{
    
    private Player _player;
    public GameController()
    {
        
        _player = new Player();
    }
    public void StartGame()
    {
        #region VEHICLE EXPLANATION
        
        Car myCar = new Car(100f,new AlienBattery());
        myCar.StartCar();
        
         #endregion

         float force = PhysicsCalculator.Force(5, 6);

         #region GAME START

         /*
     Console.Write("Game Started. Please give your name: ");

     string playerName = Console.ReadLine();
     if (playerName == "" || playerName == null)
     {
         Console.WriteLine("There is no name here! You are dead to me");
         playerName = "Dead2Me";
     }

     Console.WriteLine("Tell me you age");
     int playerAge = _player.Age;

     if (int.TryParse(Console.ReadLine(),out int age))
     {
         playerAge = age;

         if (age < 18)
         {
             Console.WriteLine("Thank goodness this is not an 18+ game bcs you couldn't played it.");
         }
         else if ( age < 65)
         {
             Console.WriteLine("Okay, you are in our target audience.you may play.");
         }
         else
         {
             Console.WriteLine("are you sure can handle the excitement this game will dish out");
         }


     }
     else
     {
         Console.WriteLine("You did not enter a valid age.I am using the default age");
     }


     /*
     Console.WriteLine("Give me a Float: ");

     float randomFloat = 0f;

     if (float.TryParse(Console.ReadLine(), out float thisFloat))
     {
         randomFloat = thisFloat;
         Console.WriteLine($"The float is {randomFloat}");
     }
     else
     {
         Console.WriteLine("You did not enter a valid float");
     }


     _player.Initialize(playerName, playerAge);

     Console.WriteLine($"Welcome {_player.Name} of {_player.Age} years of age , to this game ");
          */

         #endregion
    }
}