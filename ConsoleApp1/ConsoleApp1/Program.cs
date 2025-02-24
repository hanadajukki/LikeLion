using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //if문

            //    int score = 85;
            //    if (score >= 90)
            //    {
            //        Console.WriteLine("A 학점");
            //    }
            //    else
            //    {
            //        Console.WriteLine("B 학점");
            //    }


            int atk=100, money,plusatk=0;
            string HaveMoney, weaponName="";

            Console.WriteLine("가지고 있는 소지금을 입력하세요.");
            HaveMoney =Console.ReadLine();
            money = Convert.ToInt32(HaveMoney);


            if((money>= 0 && money <=100))
            {
                weaponName = "무한의 대검";
                plusatk = 1;
            }
            else if((money <= 200 && money >=101))
            {
                weaponName = "카타나";
                plusatk = 2;
            }
            else if((money <= 300 && money >=201))
            {
                weaponName = "진은검";
               plusatk = 3;
            }
            else if((money <= 400 && money >= 301))
            {
                weaponName = "진판검";
                plusatk = 4;
            }
            else if(money <= 500 && money >=401)
            {
                weaponName = "엑스칼리버";
                plusatk = 5;
            }
            else if(money>=501 && money <=600)
            {
                weaponName = "유령검";
                plusatk = 6;
            }
            else
            {
                weaponName = "전설의 대검";
                plusatk = 7;
            }

                Console.WriteLine("캐릭터 멋sssss사검존");
            Console.WriteLine("무기: "+weaponName);
            atk = atk + plusatk;
            Console.WriteLine("공격력: "+atk);
        }

       

    }
}
