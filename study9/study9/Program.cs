using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study9
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열
            //0부터 시작한다.

            //int[] num = new int[3]; //3개 메모리를 만들겠다.

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;

            //for(int i=0;i<3;i++)
            //    Console.WriteLine(num[i]);

            //int[] numbers = { 1, 2, 3 }; //간단한 선언과 초기화
            //int[] number2 = new int[3]; //크기만 지정
            //int[] number3 = new int[] { 1, 2, 3 }; //초기화와 함께 선언

            //for(int i=0;i<3;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] fruits = { "사과", "바나나", "오렌지" };

            //for(int i=0;i<3;i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            //3명의 
            //국어, 영어, 수학 점수를 입력받고
            //총점과 평균을 출력하세요.

            //int[] math=new int[3];
            //int[] eng = new int[3];
            //int[] kor = new int[3];

            //int[] sum = new int[3];
            //float[] aver = new float[3];

            //string[] mathInput = new string[3];
            //string[] engInput = new string[3];
            //string[] korInput = new string[3];

            //Console.WriteLine("학생점수를 입력하세요.");
            //for (int i=0;i<3;i++)
            //{
            //    Console.Write("국어: ");
            //    korInput[i] = Console.ReadLine();
            //    kor[i] = int.Parse(korInput[i]);
            //    Console.Write("영어: ");
            //    engInput[i] = Console.ReadLine();
            //    eng[i] = int.Parse(engInput[i]);
            //    Console.Write("수학: ");
            //    mathInput[i] = Console.ReadLine();
            //    math[i] = int.Parse(mathInput[i]);

            //    sum[i] = kor[i] + eng[i] + math[i];
            //    aver[i] = (float)sum[i] / 3.0f;
            //}

            //for(int i=0;i<3;i++)
            //{
            //    Console.WriteLine($"{i + 1}번 학생");
            //    Console.WriteLine($"국어: {kor[i]} 영어: {eng[i]} 수학: {math[i]}");
            //    Console.WriteLine("총점: " + sum[i]);
            //    Console.WriteLine("평균: " + aver[i].ToString("F2"));
            //}

            //1차원 배열
            //int[] scores = new int[3];

            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;

            //for(int i=0; i<scores.Length;i++)
            //{
            //    Console.WriteLine($"점수: {i + 1}:{scores[i]}");
            //}

            //double value = 123.456789;

            //Console.WriteLine(value.ToString("F2"));
            //Console.WriteLine($"소수점 둘째자리 : {value.ToString("F2")}");

            //2차원 배열 선언
            //int[,] matrix = new int[2, 3] {{1,2,3},{4,5,6}};

            //for(int i=0;i<2;i++)
            //{
            //    Console.WriteLine("i = " +i);
            //    for(int j=0;j<3;j++)
            //    {
            //        Console.WriteLine("j = "+ j);
            //    }
            //    Console.WriteLine();
            //}

            //for(int i=0;i<2;i++)
            //{
            //    for(int j=0;j<3;j++)
            //    {
            //        Console.Write($"{matrix[i, j]}");
            //    }
            //    Console.WriteLine();
            //}

            //int[][] matrix = new int[2][];

            //matrix[0]= new int[3];
            //matrix[1] = new int[3];

            //matrix[0][0] = 1;
            //matrix[0][1] = 2;
            //matrix[0][2] = 3;

            //matrix[1][0] = 4;
            //matrix[1][1] = 5;
            //matrix[1][2] = 6;

            ////출력
            //for(int i=0;i<matrix.Length;i++)
            //{
            //    for(int j = 0; j < matrix[i].Length;j++)
            //    {
            //        Console.Write(matrix[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //6. 가변배열
            Console.WriteLine("가변배열");
            int[][] jaggledArray = new int[3][];

            jaggledArray[0] = new int[] { 1, 2 };
            jaggledArray[1] = new int[] { 3, 4, 5 };
            jaggledArray[2] = new int[] { 6 };

            for(int i=0; i<jaggledArray.Length;i++)
            {
                for(int j=0; j < jaggledArray[i].Length;j++)
                {
                    Console.Write($"{jaggledArray[i][j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("var 키워드 사용");
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입: {numbers.GetType()}");

            
        }
    }
}
