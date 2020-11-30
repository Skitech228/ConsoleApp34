using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp34
{
    public class DelegatesContext
    {
        public void Show_Message(PrintSmile _del, int a,string b)
        {
            _del?.Invoke(1);
            Show_Message2(GetHappy, a,b);
            Show_Message2(GetHappy, n => n % 2 == 0, b);
        }

        private void Show_Message2(Func<int, string> getHappy, Func<int, bool> p, string b)
        {
            Console.WriteLine(p.Invoke(1));
        }

        public void Show_Message2(Func<int,string> _del, int a, string b)
        {
            _del?.Invoke(1);
        }
        public void Show_Message3(PrintSmile _del, int a, string b)
        {
            _del?.Invoke(1);
            Show_Message2(GetHappy, a, b);
        }
        public delegate string PrintSmile(int i);
        public DelegatesContext()
        {
            PrintSmile smile = null;
            while (true)
            {
                Console.WriteLine("1. Веселый");
                Console.WriteLine("2. Задумчивый");
                Console.WriteLine("3. Грустный");
                Console.WriteLine("4. Обдолабнный");
                if (int.TryParse(Console.ReadLine(), out int answer))
                {
                    switch (answer)
                    {
                        case 1:
                            {
                                smile = GetHappy;
                                break;
                            }
                        case 2:
                            {
                                smile = GetPensive;
                                break;
                            }
                        case 3:
                            {
                                smile = GetSad;
                                break;
                            }
                        case 4:
                            {
                                smile = Agreeeee;
                                break;
                            }
                    }
                }
                smile(1);
                Show_Message(smile, 4, "sdfsd");
            }
        }
        public static string GetHappy(int i)
        {
            string happy = "**************\n" +
                           "*    |    |  *\n" +
                           "*   \\      / *\n" +
                           "*    ----    *\n" +
                           "*            *\n" +
                           "**************";
            Console.WriteLine(happy);
            i = 1;
            return happy;
        }

        private string GetPensive(int i)
        {
            string penis = "**************\n" +
                           "*   O    -   *\n" +
                           "*            *\n" +
                           "*    ---/    *\n" +
                           "*            *\n" +
                           "**************";
            Console.WriteLine(penis);
            i = 2;
            return penis;
        }

        private string GetSad(int i)
        {
            string sad = "**************\n" +
                           "*   -    -   *\n" +
                           "*    ----    *\n" +
                           "*   /    \\  *\n" +
                           "*            *\n" +
                           "**************";
            Console.WriteLine(sad);
            i = 3;
            return sad;
        }
        public static string Agreeeee(int i)
        {
            string happy = "**************\n" +
                           "*   __   __  *\n" +
                           "*   ()   ()  *\n" +
                           "*    ----    *\n" +
                           "*            *\n" +
                           "**************";
            Console.WriteLine(happy);
            i = 1;
            return happy;
        }
    }
}