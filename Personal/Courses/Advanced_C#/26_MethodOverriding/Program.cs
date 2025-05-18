using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canli life = new Canli();
            Kedi cat = new Kedi();
            Kopek dog = new Kopek();


            cat.Sound();
            dog.Sound();
            life.Sound();


            Console.ReadKey();
        }
    }

    class Canli
    {
        public virtual void Sound() 
        {
            Console.WriteLine("-------");
        }
    }

    class Kedi : Canli 
    {
        public override void Sound()
        {
            Console.WriteLine("Meooww.");
        }
    }

    class Kopek : Canli 
    {
        public override void Sound() 
        {
            Console.WriteLine("haw haw haw.");
        }
    }
}
