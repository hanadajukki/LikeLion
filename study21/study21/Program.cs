using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace study21
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("프로그램종료");

            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH: {path}");

            //Environment.Exit(0);

            //Random rand = new Random();
            //int randomNo = rand.Next(1, 101);
            //Console.WriteLine("랜덤 숫자: " + randomNo);

            //Stopwatch stopwatch = Stopwatch.StartNew();

            ////실행코드
            //for(int i=0;i<100; i++)
            //{
            //    Thread.Sleep(1);
            //}

            //stopwatch.Stop();

            //Console.WriteLine("포문 시간 : " + stopwatch.ElapsedMilliseconds);

            //string input = "Hello, my phone number is 010-1234-5678.";
            //string pattern = @"\d{3}-\d{4}-\d{4}"; //전화번호 패턴

            //bool isMatch = Regex.IsMatch(input, pattern);
            //Console.WriteLine($"전화번호가 존재하는가? {isMatch}");

            //클래스 시그니처 기본구성
            //C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

            //[접근 지성자]  [수정자]   class 클래스이름 : 부모클래스, 인터페이스
            //public        abstract                   : BaseClass, IComparable
            //private       sealed
            //protected     static
            //protected     partial



        }
        public class Player
        {
            public string Name { get; set; }
            public int Score { get; set; }
        }

        //상속하는 클래스
        public class Warrior : Player
        {
            public int Strength { get; set; }
        }

        //인터페이스를 구현하는 클래스
        //public class Enemy:IAttackable, IMovable
        //{
        //    public void Attack() { }
        //    public void Move() { }
        //}

        //추상 클래스

        public abstract class Animal
        {
            public abstract void makeSound();
        }
    }
}
