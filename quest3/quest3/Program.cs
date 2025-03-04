using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest3
{
    class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        static int countLetter(string letter)
        {
            int count = letter.Length;

            

                return count;
        }

        static int max(int a,int b, int c)
        {
            int max = a;
            if(max<b)
            {
                max = b;
                if (max < c)
                    max = c;
            }

            return max;
        }

        static void Main(string[] args)
        {
            ////1번문제
            //int[] number = new int[5] { 10, 20, 30, 40, 50 };

            //for (int i = 0; i < 5; i++)
            //    Console.Write(number[i] +" ");

            //2번 문제
            //int[] number3 = new int[5];
            //int sum = 0;
            //Console.WriteLine("정수 5개를 입력하세요.");
            //for (int i = 0; i < 5; i++)
            //{
            //    number3[i] = int.Parse(Console.ReadLine());
            //    sum += number3[i];
            //}

            //Console.WriteLine("총 합:" + sum);

            //3번문제
            //int[] number2 = new int[5];
            //int max = 0;
            //Console.WriteLine("정수 5개를 입력하세요.");
            //for (int i = 0; i < 5; i++)
            //{
            //    number2[i] = int.Parse(Console.ReadLine());
            //    if (number2[i] > max)
            //    {
            //        max = number2[i];
            //    }


            //}
            //Console.WriteLine("최대수"+max);

            //4번문제

            //int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < 10; i++)
            //    Console.Write(a[i] + " ");

            //5번문제

            //int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int i = 0;
            //while(i<10)
            //{
            //    if (b[i] % 2 == 0)
            //    {
            //        Console.Write(" " + b[i]);
            //        i++;
            //    }
            //    else i++;
            //}

            //6번문제

            //    int[] cs= { 1, 2, 3, 4, 5 };

            //    foreach (int c in cs)
            //        Console.Write(c+" ");

            //int a = 3, b = 5;
            //Console.WriteLine("3과 5의 합: " + add(a, b));

            //int[] a=new int[3];
            //Console.WriteLine("숫자를 입력하세요");
            //for(int i=0;i<3;i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("가장 큰 수: " + max(a[0], a[1], a[2]));

            string letter="Hello";

            Console.WriteLine("글자 수:"+countLetter(letter));
        }
    }
}
