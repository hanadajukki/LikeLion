using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study25
{
    class Cup<T>
    {
        public T Content { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Cup<String> cupOfString = new Cup<string> { Content = "Coffee" };
            //Cup<int> cupofInt = new Cup<int> { Content = 42 };

            //Console.WriteLine($"CupofString: {cupOfString.Content}");
            //Console.WriteLine($"CupofInt: {cupofInt.Content}");

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //while(stack.Count>0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");

            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //IEnumerator
            //C#컬렉션 순회 반복할수있는 인터페이스

            //ArrayList list = new ArrayList { "Apple","Banana","Cherry"};

            //IEnumerator enumerator = list.GetEnumerator(); //열거자 가져오기

            //while(enumerator.MoveNext()) //다음 요소가 있는지 확인
            //{
            //    Console.WriteLine(enumerator.Current); //현재 요소 출력
            //}

            //커스텀컬렉션

            //Dictionary<string, int> ages = new Dictionary<string, int>();
            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;

            //foreach(var pair in ages)
            //{
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}

            //null값
            //참조형식 null을 가질수 있으며, 값 형식은 기본적으로 null을 가질수 없습니다.

            //string str = null;
            //if(str==null)
            //{
            //    Console.WriteLine("str is null");
            //}

            //    int? nullableInt = null;

            //    Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //    nullableInt = 10;
            //    Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            //?? 연산자를 사용해 null인 경우 대체값을 제공하고, ?.은 null안전 접근을 합니다.

            //string str = null;

            //Console.WriteLine(str ?? "DefaultValue"); //str이 null이면 "Default Value"

            //str = "Hello";

            //Console.WriteLine(str?.Length); //str이 null이 아니므로 길이 출력

            int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }

       
    }
}
