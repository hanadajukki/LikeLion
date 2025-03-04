using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study13
{
    class Program
    {
        //params 키워드 (가변 매개변수)

        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        //재쥐함수(자기자신을 호출)
        static int factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * factorial(n - 1);
            
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(1, 2, 3));
            //Console.WriteLine(Sum(1, 2, 3,4,5,6,7,8,9,10));
            Console.WriteLine(factorial(5));
        }


    }
}
