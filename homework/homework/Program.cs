using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1번 세개의 정수 최대값 구하기

            //int num1, num2, num3;
            //string numInput1, numInput2, numInput3;

            //Console.WriteLine("정수 3개를 입력하세요");
            //numInput1 = Console.ReadLine();
            //numInput2 = Console.ReadLine();
            //numInput3 = Console.ReadLine();

            //num1 = Convert.ToInt32(numInput1);
            //num2 = Convert.ToInt32(numInput2);
            //num3 = Convert.ToInt32(numInput3);

            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //    {
            //        Console.WriteLine("가장 큰수는 " + num1);
            //    }
            //    else
            //    {
            //        if (num2 > num3)
            //        {
            //            Console.WriteLine("가장 큰수는 " + num2);
            //        }

            //        else
            //        {
            //            Console.WriteLine("가장 큰수는 " + num3);
            //        }
            //    }
            //}
            //else
            //{
            //    if(num2>num3)
            //    {
            //        Console.WriteLine("가장 큰수는 " + num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("가장 큰수는 " + num3);
            //    }
            //}

            //        int score;
            //        string scoreInput;

            //        Console.WriteLine("학점을 입력하세요.");
            //        score = Convert.ToInt32(Console.ReadLine());

            //        if (score < 60)
            //        {
            //            Console.WriteLine("F학점");
            //        }
            //        else if (score>=60 && score <70)
            //        {
            //            Console.WriteLine("D학점");
            //        }
            //        else if(score>=70 && score<80)
            //        {
            //            Console.WriteLine("C학점");
            //        }
            //        else if(score>=80 && score<90)
            //        {
            //            Console.WriteLine("B학점");
            //        }
            //        else
            //        {
            //            Console.WriteLine("A학점");
            //        }

            int num1, num2;
            string op;
            int result = 0;

            Console.WriteLine("숫자를 입력하세요.");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("연산자를 입력하세요.");
            op = Console.ReadLine();
            Console.WriteLine("숫자를 입력하세요.");
            num2 = Convert.ToInt32(Console.ReadLine());

  
            if(op=="+")
            {
                result = num1 + num2;
                Console.WriteLine(result);
            }
            else if (op == "-")
            {
                result = num1 - num2;
                Console.WriteLine(result);
            }
            else if (op == "*")
            {
                result = num1 * num2;
                Console.WriteLine(result);
            }
            else if (op == "/")
            {
                if(num2==0)
                {
                    Console.WriteLine("에러");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine(result);
                }
            }

            else 
            {
                Console.WriteLine("연산자를 잘못입렸했습니다.");
            }
        }

      

        

    }
}
