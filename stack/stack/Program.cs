using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        int[] n;
        int size = 1;
        static void Main(string[] args)
        {
           
        }

        int pop(int size)
        {
            if (size <= 0)
            {
                Console.WriteLine("Empty");
                return size;
            }
            else
            {
                Console.WriteLine(n[--size]);
                return size;
            }    
                
        }

        int push(int size)
        {

            return size;
        }
    }
}
