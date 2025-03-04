using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study17
{
    class Program
    {
        // C# 구조체
        // 클래스와 비슷하지만, 값타입(value type)이며 가볍고 빠름
        // 주로 간단한 데이터 묶음을 만들때 사용

        struct Point
        {
            //public 어디서든 사용가능하게 권한
            //private 나만 사용할려고 하는 키워드
            public int x;
            public int y;

            public void Print()
            {
                Console.WriteLine($"좌표 : {x} , {y}");
            }
            //생성자 정의

            public Point(int X, int Y)
            {
                x = X;
                y = Y;
            }

            

        }

        struct Rectangle
        {
            public int Width;
            public int Height;

            public int GetArea() => Width * Height;
        }

        struct Student
        {
            public string name;
            public int kor;
            public int eng;
            public int math;

            public void Print()
            {
                Console.WriteLine($"{name,-3} {kor,5} {eng,7} {math,8}");
            }
        }

        static void Main(string[] args)
        {
            //Point p; //구조체 선언

            //p.x = 10;
            //p.y = 20;

            //p.Print();

            //Point p1 = new Point(5, 15);

            //p1.Print();

            //Rectangle rect;
            //rect.Width = 10;
            //rect.Height = 20;
            //Console.WriteLine($"Area : {rect.GetArea()}");

            //Point[] points = new Point[2];

            //points[0].x = 10;
            //points[0].y = 10;

            //points[1].x = 20;
            //points[1].y = 20;

            //foreach(var point in points)
            //{
            //    Console.WriteLine($"Point: ({point.x},{point.y})");
            //}

            Student[] student = new Student[3];

            for (int i = 0; i < 3; i++) {
                Console.WriteLine("학생이름을 입력하세요.");
                student[i].name = Console.ReadLine();
                Console.WriteLine("국어 성적을 입력하세요");
                student[i].kor = int.Parse(Console.ReadLine());
                Console.WriteLine("수학 성적을 입력하세요");
                student[i].math = int.Parse(Console.ReadLine());
                Console.WriteLine("영어 성적을 입력하세요");
                student[i].eng = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름   국어  수학  영어");
            foreach(Student std in student)
            {
                std.Print();
            }
           
        }
    }
}
