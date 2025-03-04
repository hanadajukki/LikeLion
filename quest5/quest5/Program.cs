using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest5
{
    class Job
    {
        public string Name { get; set; }
        public int Score { get; set; }
        
    }

    class Warrior : Job
    {
        public int Strength;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Warrior warrior = new Warrior();

            //warrior.Name = "강대근";
            //warrior.Score = 100;
            //warrior.Strength = 55;

            //Console.WriteLine($"전사 이름: {warrior.Name} 점수: {warrior.Score} 힘: {warrior.Strength}");



            //try 
            //{
            //    int number;
            //    Console.WriteLine("숫자를 입력하세요.");
            //    number = int.Parse(Console.ReadLine());
            //    Console.WriteLine(number);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("정수를 입력하세요.");
            //}

            //List<string> fruits = new List<string>();

            //fruits.Add("사과");
            //fruits.Add("바나나");
            //fruits.Add("포도");

            //foreach (var fruit in fruits)
            //{
            //    Console.Write(fruit +" ");
            //}
            //Console.WriteLine();

            //Queue<string> tasks = new Queue<string>();

            //tasks.Enqueue("첫 번째 작업");
            //tasks.Enqueue("두 번째 작업");
            //tasks.Enqueue("세 번째 작업");

            //foreach (var task in tasks)
            //{
            //    Console.Write(task+"\t");
            //}
            //Console.WriteLine();

            //Stack<int> numbers = new Stack<int>();
            //numbers.Push(10);
            //numbers.Push(20);
            //numbers.Push(30);

            //foreach(int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();

            //string str= "Hello, C# World!";

            //var upper = str.ToUpper();
            //var replace = str.Replace("C#","CSharp");
            //var length = str.Length;

            //Console.WriteLine("대문자변환: "+upper);
            //Console.WriteLine("C#->CSharp: "+replace);
            //Console.WriteLine("길이: "+length);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = numbers.Sum();

            var evenNumber = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("짝수");
            foreach (var num in evenNumber)
            {
                Console.WriteLine(num);
                
            }
            
            Console.WriteLine("짝수 합:"+sum);
        }

        
        
        
    }
}
