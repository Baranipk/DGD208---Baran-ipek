using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game  game = new Game();
            game.GameStart();
            Console.WriteLine("Paranız bitti");
            Console.ReadKey();
        }
    }
}
