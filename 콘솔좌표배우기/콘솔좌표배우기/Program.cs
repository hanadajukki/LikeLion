using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 콘솔좌표배우기
{
    class Program
    {
        static void Main(string[] args)
        {

            //콘손 창 크기 설정
            Console.SetWindowSize(80, 25);

            //콘솔 버퍼 크기도 설정(스크롤없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);

            Console.Title = "멋사콘솔게임만들기";

            Console.CursorVisible = false; //커서 숨기기

            //Console.Clear(); //화면 지우기
            //Console.SetCursorPosition(40, 13);
            //Console.Write("대장장이키우기");
            //Thread.Sleep(5000);

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┒");
            for(int i = 1; i <= 19; i++) 
            { 
                Console.SetCursorPosition(0, i);
                Console.Write("┃                                                                             ┃");
            }
            Console.SetCursorPosition(0, 20);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Thread.Sleep(3000);

            Console.Clear();

            for(int x=0; x<30; x++)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┒");
                for (int i = 1; i <= 19; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("┃                                                                             ┃");
                }
                Console.SetCursorPosition(0, 20);
                Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

                
                Console.SetCursorPosition(x, 10);
                Console.Write("◎");
                Thread.Sleep(100);
            }
        }
    }
}
