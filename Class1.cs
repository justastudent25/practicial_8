using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPechat
{
    internal class write
    {
        int posicia_x = 0;
        int posicia_y = 0;
        public int okno = 0;
        public int okno2 = 0;
        int schetchik1 = 0;
        int schetchik2 = 0;

        public void wr(string txt, string name)
        {
            char[] c = txt.ToArray();
    
            if (okno == 0)
            {

                foreach (char i in c)
                {
                    Console.SetCursorPosition(0, 25);
                    ConsoleKeyInfo key = Console.ReadKey();
                    char knopka = key.KeyChar;
                    Console.SetCursorPosition(0, 25);
                    Console.WriteLine("     ");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("     ");
                    if (proga.time == 0)
                    {
                        okno = 1;
                        break;
                    }

                    try
                    {
                        if (knopka == i)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(posicia_x, posicia_y);
                            Console.WriteLine(knopka);
                            schetchik2++;
                            posicia_x++;
                        }
                        else if (knopka != i)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(posicia_x, posicia_y);
                            Console.WriteLine(knopka);
                            schetchik1++;
                            schetchik2++;
                            posicia_x++;
                        }
                    }
                    catch { posicia_y += 1; posicia_x = 0; }

                }
                okno = 1;
                proga.islitenning = false;
            }
            else if (okno == 1)
            {
                okno = 1;
                double sec = ((double)schetchik2 / (double)proga.time) / 60;
                double min = ((double)schetchik2 / (double)proga.time);
                Console.SetCursorPosition(0, 14);
                Console.WriteLine("Имя - " + name);
                Console.WriteLine("Ваш результат символов в секунду - " + sec);
                Console.WriteLine("Ваш результат символов в минуту - " + min);
                Console.WriteLine("Количевство ошибок - " + schetchik1);
                Console.WriteLine("Нажмите enter чтобы сохранить");
                ConsoleKeyInfo keyn = Console.ReadKey();
                if (keyn.Key == ConsoleKey.Enter)
                {
                    user statistic = new user();
                    statistic.Name = name;
                    statistic.word_second = sec;
                    statistic.word_minute = min;
                    statistic.word_error = schetchik1;
                    statistika.Statistica(statistic);
                }
                else if (keyn.Key == ConsoleKey.F1)
                {
                    okno = 2;
                    okno2 = 2;
                }
                
            }
        }

        public void menu(string name)
        {
            okno2 = 0;
            proga.time = 60;
            Console.Clear();
            string text = "Богоподное поселение святых угодников не выдержало голодомора.";
            proga.islitenning = true;
            Console.WriteLine(text);
            if (okno != 2)
            {
                proga.potok.Start();
            }
            
            okno = 0;
            posicia_x = 0;
            posicia_y = 0;
            schetchik1 = 0;
            wr(text, name);
        }
    }
}
