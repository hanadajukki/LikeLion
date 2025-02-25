using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study8
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 1;

            //switch(day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("수요일");
            //        break;

            //}

            //캐릭터를 선태하세요(1. 검사 2.마법사 3.도적):
            //스위치 문 사용
            //1
            //검사
            //공격력 100
            //방어력 90

            //마법사
            //공격력 110
            //방어력 80

            //도적
            //공격력 115
            //방어력 70

            //    string selectNum;
            //    int selectNumIn;
            //    int atk, def;
            //    string job;

            //    Console.WriteLine("캐릭터를 선택하세요. 1.검사 2.마법사 3.도적");
            //    selectNum = Console.ReadLine();
            //    selectNumIn = Convert.ToInt32(selectNum);
            //    switch (selectNumIn)
            //    {
            //        case 1:
            //                job = "검사";
            //                atk = 100;
            //                def = 90;

            //            Console.WriteLine(job);
            //            Console.WriteLine("공격력: " + atk);
            //            Console.WriteLine("방어력: " + def);
            //            break;
            //        case 2:
            //                job = "마법사";
            //                atk = 110;
            //                def = 80;

            //            Console.WriteLine(job);
            //            Console.WriteLine("공격력: " + atk);
            //            Console.WriteLine("방어력: " + def);
            //            break;
            //        case 3:
            //                job = "도적";
            //                atk = 115;
            //                def = 70;

            //            Console.WriteLine(job);
            //            Console.WriteLine("공격력: " + atk);
            //            Console.WriteLine("방어력: " + def);
            //            break;

            //    }

            //반복문

            //초기화 / 조건문 /증감식
            //for(int i=1;i<=5;i++)
            //    {
            //        Console.WriteLine("숫자  : " + i);
            //    }    

            //for(int i=0;i<=9;i++)
            //    {
            //        Console.WriteLine(i);
            //    }

            //int sum = 0;

            //for(int i=1; i<11; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //while문

            //int count = 1; //초기화

            //while(count<=5) //조건
            //{
            //    Console.WriteLine("Count : " + count);

            //    count++; //증가, 감소

            //    if(count==3)
            //    {
            //        Console.WriteLine("3일때 반복문 탈출");
            //            break;
            //    }
            //}

            //랜덤

            //Random rand = new Random(); //Random 객체를 생성한다.

            ////0이상 10 미만의 랜덤 정수를 생성

            //int randomNum = rand.Next(0, 10);
            //Console.WriteLine("0이상 10미만의 랜덤 정수 : " + randomNum);

            //대장장이 키우기
            //도끼등급 SSS  10%
            //도끼등급 SS   40%
            //도끼등급 S    50%

            //Random rand = new Random();

            //for (int i = 1; i < 20; i++)
            //{

            //    int axe = rand.Next(1, 100);

            //    if (axe >= 1 && axe <= 10)
            //    {
            //        Console.WriteLine("SSS");
            //    }
            //    else if (axe >= 11 && axe <= 40)
            //    {
            //        Console.WriteLine("SS");
            //    }
            //    else
            //        Console.WriteLine("S");
            //    Thread.Sleep(1000);
            //}


            //do while
            //1회 무조건 실행, while문과 같이 조건 진행

            //    int x = 5;

            //    do
            //    {
            //        Console.WriteLine("최소 한번은 실행됩니다.");
            //        x--;
            //    } while (x > 0);

            //for(int i=1;i<=10;i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(i);
            //}

            //continue
            //현재 반복을 건너뛰고 다음 반복으로 넘어간다.

            //for(int i=1; i<=10; i++)
            //{
            //    if(i%2==0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i); //홀수만 출력
            //}


            //goto

            //int n=1;

            //start:

            //if(n<=5)
            //{
            //    Console.WriteLine(n);
            //    n++;

            //    goto start; //레이블 이동
            //}



        }


    }
}
