using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 임시게임
{
    class Program
    {
        static void Main(string[] args)
        {

            Random lucky = new Random();
            int luckyNumFirst, luckySecond, luckyThird;
            string firstOP, secondOP, thirdOp;

            Console.SetWindowSize(80, 25);

            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false;

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            for (int i=1; i<=19; i++)
            {
                if (i==13) 
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("┃                           행운의 슬롯                                        ┃");
                }
                else { 
                    Console.SetCursorPosition(0, i);
                    Console.Write("┃                                                                              ┃");
                }
            }
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Thread.Sleep(3000);
            Console.Clear();
            
            luckyNumFirst = lucky.Next(1, 10);
            luckySecond = lucky.Next(1, 10);
            luckyThird = lucky.Next(1, 10);

            firstOP = Convert.ToString(luckyNumFirst);
            secondOP = Convert.ToString(luckySecond);
            thirdOp = Convert.ToString(luckyThird);

            Console.SetCursorPosition(30,5);
            Console.Write(firstOP);
            Thread.Sleep(1000);
            Console.SetCursorPosition(40,5);
            Console.Write(secondOP);
            Thread.Sleep(1000);
            Console.SetCursorPosition(50,5);
            Console.Write(thirdOp);
            Thread.Sleep(1000);

            if((firstOP==secondOP)&&(secondOP==thirdOp)&&(firstOP==thirdOp))
            {
                Console.SetCursorPosition(50, 10);
                Console.Write("당첨");
            }
            else
            {
                Console.SetCursorPosition(50, 10);
                Console.Write("꽝");
            }

        }
    }
}
