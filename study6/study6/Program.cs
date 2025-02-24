using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace study6
{
    class Program
    {
        static void Main(string[] args)
        {
            ////이진수를 정수로 변환
            //Console.Write("2진수를 입력하세요.");
            //string binaryInput = Console.ReadLine(); //입력받는다 문자열
            //int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수->10진수 변환

            ////정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2); //10진수->2진수

            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimalValue}");
            //Console.WriteLine($"다시 2진수로 변환 : {binaryOutput}");

            ////var사용하여 변수 선언
            //var name = "Alice"; //문자열로 추론
            //var age = 25; //정수로 추론
            //var isStudent = true; //논리값으로 추론

            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생여부: {isStudent}");

            ////default 키워드를 사용한 기본값 서정
            //int defaultInt = default; //기본값:0
            //string defaultString = default; //기본값:null
            //bool defaultBool = default; //기본값: false
            ////기본값:0
            //Console.WriteLine($"정수 기본값:{defaultInt}");  //기본값:0
            //Console.WriteLine($"정수 기본값:{defaultString}"); //기본값:null
            //Console.WriteLine($"정수 기본값:{defaultBool}");  //기본값: false

            //연산자

            //int a = 5, b = 3;
            //int sum = default; //산술연산자
            //sum = a + b;
            //Console.WriteLine($"합: {sum}"); //출력: 8
            //sum = a - b; //산술연산자
            //Console.WriteLine($"합: {sum}"); //출력: 8
            // sum = a * b; //산술연산자
            //Console.WriteLine($"합: {sum}"); //출력: 8
            // sum = a / b; //산술연산자
            //Console.WriteLine($"합: {sum}"); //출력: 8
            //bool isEqual = (a == b); //관계형 연산자 사용


            //int c = 10, d = 3;
            //int sum = c % d;
            //Console.WriteLine($"나머지: {sum}"); 
            // Console.WriteLine($"a와 b가 같은가?: {isEqual}"); //출력: false

            //int nubmer = 7;
            //int sum = default;

            //sum = nubmer % 2;

            //Console.WriteLine($"짝수 홀수 판별 : {sum}"); //0 나오면 짝수 1 홀수

            ////관계형 연산자
            //bool isEqual = false;

            //int a = 5;
            //int b = 5;

            //isEqual = (a == b); //a랑 b랑 같은가?

            //Console.WriteLine("같은가?" + isEqual);


            //단항연산자

            //int number = 5;
            //bool flag = true;

            //Console.WriteLine(+number); //양수 출력 : 5
            //Console.WriteLine(-number); //음수 출력 : -5

            //Console.WriteLine(!flag); //논리 부정: false

            //~비트 반전

            //10 1010

            //int num = 10;
            //int result = ~num; //모든 비트 반전 : 1111 0101 결과 -11

            //Console.WriteLine("원래 값: "+num + " ~적용 값: "+result);
            //Console.WriteLine("~ 연산자 적용 후"+result);

            //캐스팅
            //double pi = 3.14;
            //int intergerPi = (int)pi; //실수형 -> 정수형

            //Console.WriteLine(intergerPi); //3

            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = default;
            //float average = default;

            //sum = iKor + iEng + iMath;
            //average =(float) sum / 3.0f; //평균

            //Console.WriteLine("총점: " + sum);
            //Console.WriteLine("평균: " + average);

            //int a = 10, b = 3;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //string firstname = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstname + " " + lastName); //출력: Alice Smith

            //할당연산자

            //int a = 10;
            //a += 5;// a=a+5;
            //Console.WriteLine(a); //출력: 15


            //int a = 10;
            //a += 5;  // a  = a + 5;
            //Console.WriteLine(a);
            //a -= 5;  // a  = a - 5;
            //Console.WriteLine(a);
            //a *= 5;  // a  = a * 5;
            //Console.WriteLine(a);
            //a /= 5;  // a  = a / 5;
            //Console.WriteLine(a);
            //a %= 5;  // a  = a % 5;
            //Console.WriteLine(a);

            //int Kor, Eng, Math;
            //float average=0.0f;
            //int sum = 0;


            //Console.WriteLine("국어점수를 입력하세요");
            //string KorInput = Console.ReadLine();
            //Kor = int.Parse(KorInput);

            //Console.WriteLine("영어점수를 입력하세요");
            //string EngInput = Console.ReadLine();
            //Eng = int.Parse(EngInput);

            //Console.WriteLine("수학점수를 입력하세요");
            //string MathInput = Console.ReadLine();
            //Math = int.Parse(MathInput);

            //sum = Kor + Eng + Math;
            //average = (float)sum / 3.0f;
            //Console.WriteLine("총점: " + sum);
            //Console.WriteLine("평균: " + average.ToString("F2"));

            //string numberString;
            //int number, reverseNum;
            //string binaryString, reverseBinaryString;

            //Console.WriteLine("정수를 입력하세요.");
            //numberString = Console.ReadLine();
            //number = Convert.ToInt32(numberString);
            //reverseNum = ~number;
            //binaryString = Convert.ToString(number, 2);
            //reverseBinaryString = Convert.ToString(reverseNum, 2);

            ////Console.WriteLine("이진수: " + binaryString);

            //Console.WriteLine("반전비트: " + reverseNum);

            //증감연산자

            int b = 3;

            //전위 ++b, 후위 b++
            
            Console.WriteLine("b의 값은 : " + (++b));
            Console.WriteLine("b의 값은 : " + (b++));
            
            



        }
    }
}
