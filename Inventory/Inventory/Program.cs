using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        //최대 아이템 개수(배열크기)
        const int MAX_ITEMS = 10;
        static string[] itemNames = new string[MAX_ITEMS];
        static int[] itemcounts = new int[MAX_ITEMS];

        //아이템 추가함수
        static void AddItme(string name, int count)
        {
            for(int i=0; i<MAX_ITEMS; i++)
            {
                if (itemNames[i]==name) //이미있는 아이템이면 개수 증가
                {
                    itemcounts[i] += count;
                    return;
                }
            }

            //빈 슬롯에 새로운 아이템 추가
            for(int i=0;i<MAX_ITEMS;i++)
            {
                if (itemNames[i]==null)
                {
                    itemNames[i] = name;
                    itemcounts[i] = count;
                    return;
                }
            }

            Console.WriteLine("인벤토리가 가득찼습니다.");
        }

        //아이템 제거 함수
        static void RemoveItem(string name, int count)
        {
            for(int i=0;i<MAX_ITEMS;i++) 
            {
                if(itemNames[i]==name) //이름하고 같은지 {
                    if (itemcounts[i]>=count) //개수가 충분하면 차감
                    {
                        itemcounts[i] -= count;
                        if (itemcounts[i]==0) //개수가 0이면 삭제
                        {
                            itemNames[i] = null;
                        }
                        return;
                    }
            }
        }

        //인벤토리 출력 함수

        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리: ");
            bool isEmpty = true;

            for(int i=0;i<MAX_ITEMS;i++)
            {
                if (itemNames[i] != null)
                {
                    Console.WriteLine($" {itemNames[i]} (x{itemcounts[i]})");
                    isEmpty = false;
                }
            }

            if(isEmpty)
            {
                Console.WriteLine("인벤토리가 비어있습니다.");
            }
        }
        static void Main(string[] args)
        {
            //테스트: 아이템 추가
            AddItme("포션", 5);
            AddItme("칼", 1);
            AddItme("포션", 3);

            ShowInventory();

            //아이템사용
            Console.WriteLine("포션 2개 사용");
            RemoveItem("포션", 2);
            ShowInventory();

            //없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            RemoveItem("방패", 1);

            ShowInventory();

            //테스트: 모든 포션 제거
            Console.WriteLine("포션 6개 사용(초과 사용 테스트)");
            RemoveItem("포션", 7);

            ShowInventory();
        }
    }
}
