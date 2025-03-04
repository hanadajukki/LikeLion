using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study20
{
    //class Person
    //{
    //    private string name; //내부 변수

    //    ////값 설정하기 (Setter)
    //    //public void SetName(string newName)
    //    //{
    //    //    name = newName;
    //    //}


    //    ////값 가져오기 (Getter)
    //    //public string GetName()
    //    //{
    //    //    return name;
    //    //}

    //    //public string Name //프로퍼티 
    //    //{
    //    //    get { return name; } //getter
    //    //    set { name = value; } //set
    //    //}

    //마린클래스
    //프로퍼티이용해서 이름과 미네랄을 만드시오. 이름 마린 미네랄 50

    class Marin
    {
        public string name { get; private set; } = "마린";
        public int mineral { get; set; }
    }
    class Person
    {
        public string Name { get; set; }
        public int count=100;
        public int Count //읽기만 가능
        {
            get { return count; }
        }

        public float Balance { get; private set; } //외부변경 불가

        public void addBal()
        {
            Balance += 100;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //C#에서 get/set/ 방식의 함수와 프로퍼티 비교
            //C#에서는 객체의 읽고(get), 설정(set)하는
            //방식으로 함수(get/set 메서드) 또는
            //**프로퍼티(propoerty)**를 사용할 수 있습니다.
            Person p = new Person();
            //p.SetName("홍길동");

            //Console.WriteLine("이름 : " + p.GetName());
            p.Name = "홍길동";
            p.addBal();

            Console.WriteLine("이름 : " + p.Name +" Count: " + p.Count + " Balance: " + p.Balance);

            Marin m = new Marin();
            Console.WriteLine($"이름: {m.name} 미네랄: {m.mineral}");
            
            
        }
    }

}
