using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPechat
{
    public class proga
    {
        static write writ = new write();
        public static int time = 60;
        public static Thread potok = new Thread(new ThreadStart(timer));
        public static bool islitenning = true;
        public static void timer()
        {
            while (islitenning == true)
            {
                if (time > 0)
                {
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("Время - " + time);
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("     ");
                    time--;
                }
                else if (time <= 0)
                {
                    islitenning = false;
                }
            }
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Время - " + time);
        }
    }
}
