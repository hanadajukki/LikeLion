using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study7
{
    class Program
    {
        static void Main(string[] args)
        {
            //두 값을 비교하여 관계를 평가한다.
            // == 같다 != 같지 않다. a < b  c > d  <= =>
            // 

            //int x = 5, y = 10;

            //Console.WriteLine(x < y);  // true
            //Console.WriteLine(x == y); // false
            //Console.WriteLine(x != y); // true
            //Console.WriteLine(x > y); //false
            //Console.WriteLine(x >= y); //true

            //논리연산자

            //bool a = true;
            //bool b = false;

            //Console.WriteLine(a && b); // AND
            ///*
            // * AND 1-1 1 / 1-0 0 / 0-1 0 / 0-0 0
            // */ 
            //Console.WriteLine(a || b); // OR
            ///*
            // * OR 1-1 1 / 1-0 1 / 0-1 1 / 0-0 0
            // */

            ////NOT !a

            //Console.WriteLine(!a); //true

            //비트 연산자
            //int x = 5; //0101
            //int y = 3; //0011

            //Console.WriteLine(x & y); // AND : 1(0011)
            //Console.WriteLine(x | y); // OR : 7(0111)
            //Console.WriteLine(x ^ y); // XOR : 6(0110)
            //Console.WriteLine(~x); // NOT: -6

            //시프트 연산자

            //int value = 4; //0100

            //Console.WriteLine(value << 1); // 왼쪽이동 : 8 (1000)
            //Console.WriteLine(value >> 1); // 오른쪽이동: 2 (0010)

            //int a = 10, b = 20;

            //int max;

            //max = (a > b) ? a : b; // 삼항 연산자

            //Console.WriteLine(max);

            //// (비교) ? 참 : 거짓 ;

            //int key = 1;
            //string str;
            //str = (key == 2) ? "문이 열렸습니다" : "문이 안열렸습니다";
            //Console.WriteLine(str);

            //int result = 10 + 2 * 5;
            //Console.WriteLine(result);

            //int adjustResult = (10 + 2) * 5;
            //Console.WriteLine(adjustResult);
        }
    }
}
