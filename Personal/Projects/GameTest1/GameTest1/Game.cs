using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameTest1
{
    internal class Game
    {
        private float bakiye= 50;
        private int bahisMiktar;
        private int bahisZar;
        private int maxZar = 6;
        private float bahisOran;
        public int gelenZar;

        public Game() 
        {           


        }

        private void BahisInfo()
        {   
            Console.WriteLine("1 değeri için oran : 1.0 ");
            Console.WriteLine("2 değeri için oran : 1.25 ");
            Console.WriteLine("3 değeri için oran : 1.5 ");
            Console.WriteLine("4 değeri için oran : 2.0 ");
            Console.WriteLine("5 değeri için oran : 2.5 ");
            Console.WriteLine("6 değeri için oran : 3.0 ");
            Console.WriteLine($"Bakiye: {bakiye}");
            
            
        }
        public void GameStart()
        {
            while (true)
            {
                BahisInfo();
                WriteGetMoney();
                WriteGetZar();
                BahisOran();
                bakiye -= bahisMiktar;
                GameLoop();
                if (bakiye <= 0) 
                {
                    break;
                }
            }
            
        }

        public void WriteGetZar()
        {
            do
            {
                Console.Write("Zar İçin Bir değer seçin [1-6] : ");
            }
            while (!(CheckZarInput() && bahisZar <= maxZar && !(bahisZar <= 0)));
        }

        public void WriteGetMoney() 
        {            
            do
            {
                Console.Write("Yatırılacak para belirleyiniz : ");
            }
            while (!(CheckMoneyInput() && bahisMiktar <= bakiye));

            
        }
         
        public bool CheckMoneyInput()
        {
            try
            {
                bahisMiktar = int.Parse(Console.ReadLine());
                
                
            }

            catch
            {
                Console.WriteLine("Lütfen Bir sayı giriniz!");
                return false;
            }
            return true;
        }

        public bool CheckZarInput()
        {
            try
            {
                bahisZar = int.Parse(Console.ReadLine());


            }

            catch
            {
                Console.WriteLine("Lütfen 1 ile 6 arasında bir sayı giriniz!");
                return false;
            }
            return true;
        }

        public void BahisOran()
        {
            switch (bahisZar)
            {
                case 1:
                    bahisOran = 1f;
                    break;
                case 2:
                    bahisOran = 1.25f;
                    break;
                case 3:
                    bahisOran = 1.5f;
                    break;
                case 4:
                    bahisOran = 2f;
                    break;
                case 5:
                    bahisOran = 2.5f;
                    break;
                case 6:
                    bahisOran = 3f;
                    break;
                default:
                    break;

            }
   
        }

        public void GameLoop()
        {
           Random zar = new Random();
           gelenZar = zar.Next(1,6);

            Console.WriteLine($"Gelen Zar: {gelenZar}");
            Console.WriteLine($"Bahis zar: {bahisZar}");

            if (!(gelenZar <= bahisZar))
            {
                bakiye += bahisMiktar * bahisOran;
                WinText();
                
            }
            else 
            {
                // bakiye -= bahisMiktar;
                LoseText();
            }

        }

        public void LoseText()
        {
            Console.WriteLine($"Bahiste kaybedilen para : -{bahisMiktar}");
        }

        public void WinText()
        {
            Console.WriteLine($"Bahiste kazanılan para : +{bahisMiktar*bahisOran}");
        }
    }
      
}
