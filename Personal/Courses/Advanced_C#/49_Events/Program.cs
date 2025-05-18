using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Events
{
   

    internal class Program
    {

        static event EventHandler myEvent;

        static void Main(string[] args)
        {
            myEvent += Program_myEvent;
            myEvent += Program_myEvent1;

            Button btn = new Button() { text = "Click", width = 15, height = 40 };

            ButtonInfo info = new ButtonInfo(); 
            info.date = "2020";


            myEvent(btn, info);


            Console.ReadKey();
        }

        private static void Program_myEvent(object sender, EventArgs e)
        {
            Console.WriteLine(((Button)sender).text);
            Console.WriteLine(((ButtonInfo)e).date);
        }

        public class Button
        {
            public string text;
            public double width;
            public double height;
        }

        class ButtonInfo:EventArgs
        {
            public string date;
        }

        private static void Program_myEvent1(object sender, EventArgs e) 
        {
            Console.WriteLine(((Button)sender).text);
            Console.WriteLine(((ButtonInfo)e).date);
            Console.WriteLine("2.EVENT");
        }


    }
}
