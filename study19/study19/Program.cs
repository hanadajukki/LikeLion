using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study19
{
    class Person
    {
        public string Name;
        public int Age;

        //기본 생성자
        //클래스가 객체로 생성될때 자동으로 샐행되는 특별한 메서드
        //클래스와 같은 이름 가지며, 반환형이 없다 (void도 사용하지 않음)
        //객체를 만들때 필요한 초기값을 설정할 때 사용 많이 한다.

        //public Person()
        //{

        //}

        class Marin
        {
            public string Name;
            public int Mineral;

            public Marin()
            {
                Name = "마린";
                Mineral = 50;
            }

            public Marin(string name, int mineral) 
            {
                Name = name;
                Mineral = mineral;
            }

            public void showInfo()
            {
                Console.WriteLine($"이름: {Name} 미네랄:{Mineral}");
            }
        }
        class SCV
        {
            public string Name;
            public int Mineral;

            public SCV()
            {
                Name = "마린";
                Mineral = 50;
            }

            public SCV(string name, int mineral) 
            {
                Name = name;
                Mineral = mineral;
            }

            public void showInfo()
            {
                Console.WriteLine($"이름: {Name} 미네랄:{Mineral}");
            }

        }

        class Barrack
        {
            string Name;
            int Mineral;

            public Barrack()
            {
                Name = "배럭";
                Mineral= 150;
            }

            public Barrack(string Name, int Mineral)
            {
                this.Name = Name;
                this.Mineral = Mineral;
            }

            public void showInfo()
            {
                Console.WriteLine($"이름: {Name} 미네랄:{Mineral}");
            }
        }


        class Program
        {
            static void Main(string[] args)
            {

                Game.mineral = 50;
                Game.gas = 0;
                Game.charCount = 4;
                Game.ShowInfo();
                

                //클래스
                //
                Marin marin = new Marin();
                Marin marin2 = new Marin("감염된마린",100);
                
                SCV scv = new SCV();
                SCV scv2 = new SCV("공짜 SCV",0);
                Barrack barrack = new Barrack();
                //클래스의 배열 7개 생성
                Mineral[] mineral = new Mineral[7];

                //각 배열에 new 객체화
                for(int i=0;i<mineral.Length;i++)
                {
                    mineral[i] = new Mineral();
                    mineral[i].ShowInfo();
                }

                marin.showInfo();
                marin2.showInfo();

                scv.showInfo();
                scv2.showInfo();
                barrack.showInfo();
            }
        }
        class Mineral
        {
            int count;

            public Mineral()
            {
                count = 1500;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"현재 미네랄 갯수 : {count}");
            }
        }

        class Game
        {
            public static int mineral;
            public static int gas;
            public static int charCount;

            public static void ShowInfo()
            {
                Console.WriteLine($"미네랄 : {mineral} 가스 : {gas} 인구 : {charCount}");
            }
        }


    }
}
