using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study15
{
    class Program
    {
        //일반함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        //화살표 함수
        static int AddArrow(int a, int b) => a + b;
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3,5));
            Console.WriteLine(AddArrow(3, 5));
        }
    }
}
