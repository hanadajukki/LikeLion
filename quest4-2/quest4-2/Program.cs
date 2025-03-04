using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest4_2
{
    class Program
    {
        static ConsoleKeyInfo keyInfo;



        struct pl
        {
            public int plx;
            public int ply;

            public void move()
            {


                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (ply > 0) ply--; break;
                        case ConsoleKey.DownArrow: if (ply < Console.WindowHeight - 1) ply++; break;
                        case ConsoleKey.LeftArrow: if (plx > 0) plx++; break;
                        case ConsoleKey.RightArrow: if (plx < Console.WindowWidth - 1) plx++; break;
                        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                        case ConsoleKey.Escape: return;
                    }
                }
            }
            public void print()
            {

            }
        }



        static void Main(string[] args)
        {
            string[] player = new string[]
        {
            "->",
            ">>>",
            "->",
        };
            Console.CursorVisible = false;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds;
            pl air = new pl();

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds;

                if (currentSecond - prevSecond >= 100)
                {
                    Console.Clear();

                    air.move();
                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(air.plx, air.ply + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }
                }
            }
        }
    }
}
