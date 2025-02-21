using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace todayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //로딩바 시작화면
            //게임스토리
            //비주얼노벨만들어보기
            int hp=0;//체력
            int attk=0; // 공격력
            int speed=0; //속도

            Console.WriteLine("탈출게임");
            Console.WriteLine("로딩바 엔터를 치면 스토리가 시작됩니다.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("나: 여기가 어디지?");
            Thread.Sleep(1000);
            
            Console.WriteLine("???: 게임을 시작한다. 5일안에 나가라");
            Thread.Sleep(1000);

            Console.WriteLine("나: XX, 뭐라는거야?");
            Thread.Sleep(1000);
            Console.WriteLine("나: 이럴시간 없어 빨리 나가야겠다.");
            Thread.Sleep(1000);

            Console.WriteLine("방을 나가겠습니까? y/n");
            string select1 = Console.ReadLine();
            Thread.Sleep(1000);

            if (select1 =="y")
            {
                Console.WriteLine("당신은 다른 방에 들어갔다.");
                Thread.Sleep(1000);
                
                Console.WriteLine("다른방에는 칼이 있다.");
                Thread.Sleep(1000);
                attk = attk + 1;
                Console.WriteLine("공격력이 오른 기분이다.");
                Thread.Sleep(1000);
            }
            else
                Console.WriteLine("당신은 죽었다.");
                Console.ReadLine();
            

        }
    }
}
