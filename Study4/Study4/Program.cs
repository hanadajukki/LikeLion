using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////문자열
            //string greeting; //문자열 변수를 선언
            //greeting = "Hello, World!"; //변수값을 저장

            ////변수의 값을 사용
            //Console.WriteLine(greeting); //출력: Hello, World!


            ////변수 선언과 초기화를 한번에 수행
            //int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.6; //실수형 변수 선언과 초기화
            //string city = "Seoul"; //문자열 변수 선언과 초기화

            ////변수 출력
            //Console.WriteLine(score); //출력 100
            //Console.WriteLine(temperature); //출력 36.5;
            //Console.WriteLine(city); //출력: Seoul

            ////같은 데이터 타입의 변수를 쉼표로 구분해서 선언
            //int x = 10, y = 20, z = 30; //정수형 변수 x,y,z를 선언하고 초기화

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //const double Pi = 3.14159; //상수 pi선언 및 초기화
            //const int MaxScore = 100; //정수형 상수 선언

            ////출력
            //Console.WriteLine("Pi : " + Pi);
            // Console.WriteLine(MaxScore);

            int atk=16755, maxLife=78103;
            int cri=36, spe=1017, press=41, agil=611, indure=22, exp=39;

            Console.WriteLine("기본특성");
            Console.WriteLine("공격력:"+atk);
            Console.WriteLine("최대 생명력"+maxLife);
            Console.WriteLine("전투 특성");
            Console.WriteLine("치명:"+cri);
            Console.WriteLine("특화:"+spe);
            Console.WriteLine("제압:"+press);
            Console.WriteLine("신속:"+agil);
            Console.WriteLine("인내:"+indure);
            Console.WriteLine("숙련:"+exp);
        }
    }
}
