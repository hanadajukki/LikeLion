using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace loading
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            //Console.WriteLine("□□□□□□□□□□");
           
            for (i = 0; i < 11; i++)
            {
                Thread.Sleep(1000); //1000 1초( 1000밀리초)
                //Console.Write("□");
                for(j=0; j<11; j++)
                {
                    if (j < i)
                    {
                        Thread.Sleep(500);
                        Console.Write("■");
                    }
                    else
                    {
                        Thread.Sleep(500);
                        Console.Write("□");
                        
                    }
                    
                    //Console.Clear();
                }
                Console.WriteLine(" ");
                Console.Clear(); //콘솔화면 지우기
                                 //Console.WriteLine("■□□□□□□□□□");
                
            }
            Console.WriteLine("게임시작");
        }
    }
}
