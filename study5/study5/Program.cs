﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace study5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            int interNum = 10; //정수데이터
            float floatNum = 3.14f; //단정밀도 실수
            double doubleNum = 3.1459; //배정밀도 실수

            Console.WriteLine(interNum); 
            Console.WriteLine(floatNum); 
            Console.WriteLine(doubleNum);*/

            ////정수 데이터형식: 소수점이 없는 숫자를 표현
            //int intValue = -100; //4바이트 크기의 정수
            //long longValue = 123456789L; //8바이트 크기의 정수

            //Console.WriteLine(intValue); //출력: -100
            //Console.WriteLine(longValue); //출력: 123456789

            ////부호 있는 정수: 음수와 양수를 모두 표현 가능
            //sbyte signedByte = -50; //1바이트 크기
            //short singedShort = -32000; //2바이트 크기
            //int sighnedInt = -20000000; //4바이트 크기


            ////실수형 데이터 형식: 소수점을 포함한 숫자를 표현
            //float singlePrecision = 3.14f; //단정밀도 실수
            //double doublePrecision = 3.141592156; //배정밀도 실수(8바이트)
            //decimal highPrecision = 3.1415921321321658465465m; //고정밀도 (16바이트)

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            ////char형식: 단일 문자를 표현
            //char letter = 'A'; //문자 'A' 저장
            //char symbol = '#'; //특수 기호 저장
            //char number = '9'; //숫자 형태의 문자 저장(문자 '9'는 숫자 아님

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            ////string 형식: 여러 문자를 저장
            //string greeting = "Hello World"; //문자열 저장
            //string name = "Alice"; //이름 저장

            //Console.WriteLine(greeting); //출력: Hello, World
            //Console.WriteLine(name); //출력: Alice

            ////Hello World Alice
            //Console.WriteLine(greeting +" "+ name);

            ////bool형식 : 참(true) =1 거짓(true) =0

            //bool isRunning = true; //프로그램 실행 상태
            //bool isFinished = false; //프로그램 종료 상태

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            //// const:변하지 않는 상수값
            // const double pi = 3.141592; //원주율
            // const int MaxScore = 100; //최대 점수

            // Console.WriteLine(pi);
            // Console.WriteLine(MaxScore);

            ////닷넷형식: 기본 형식의 닷넷표현
            //System.Int32 number = 123; //int닷넷형식
            //System.String text = "Hello"; //string 닷넷형식
            //System.Boolean flag = true; //bool의 닷넷형식

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);

            //int 래퍼 형식의 메서드 활용
            int number = 123;

            string numberAsString = number.ToString(); //정수를 문자열로 변환

            //bool 래퍼형식
            bool flag = true;

            string flagAsString = flag.ToString(); //논리값을 문자열로 변환

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);
        }
    }
}
