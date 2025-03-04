using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest4
{
    class Program
    {
        const int MAX_ITEMS = 10;
        static string[] itemName = new string[MAX_ITEMS];
        static int[] itemCount = new int[MAX_ITEMS];
        struct Items
        {
            public string Name;
            public int Count;

            public void addItem(string name, int count)
            {
                for(int i=0;i<MAX_ITEMS;i++)
                {
                    if (itemName[i]==name)
                    {
                        itemCount[i] += count;
                        return;
                    }
                }

                for(int i=0;i<MAX_ITEMS;i++)
                {
                    if (itemName[i]!=name)
                    {
                        itemName[i] = name;
                        itemCount[i] = count;
                        return;
                    }
                }
            }

            public void removeItem(string name, int count)
            {
                for(int i=0;i<MAX_ITEMS; i++)
                {
                    if (itemName[i]==name)
                    {
                        if (itemCount[i]>=count)
                        {
                            itemCount[i] -= count;
                            if (itemCount[i]==0)
                            {
                                itemName[i] = null;
                            }
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("아이템 개수가 부족합니다.");
                        return;
                    }
                }
            }

            public void showInventory()
            {
                Console.WriteLine("현재 인벤토리 :");
                bool isEmpty = true;

                for(int i=0;i<MAX_ITEMS;i++)
                {
                    if (itemName[i] != null)
                    {
                        Console.WriteLine($"{itemName[i]} (x{itemCount[i]}");
                        isEmpty = false;
                    }
                }

                if(isEmpty)
                {
                    Console.WriteLine("인벤토리는 비어있습니다.");
                }
            }
        }

        
        static void Main(string[] args)
        {

            Items inven = new Items();
            inven.addItem("포션", 5);
            inven.addItem("칼", 1);
            inven.addItem("포션", 3);
            inven.showInventory();

            Console.WriteLine("포션 2개 사용");
            inven.removeItem("포션", 2);
            inven.showInventory();

            //없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            inven.removeItem("방패", 1);
            inven.showInventory();

            //테스트: 모든 포션 제거
            Console.WriteLine("포션 6개 사용");
            inven.removeItem("포션", 6);
            inven.showInventory();
            
        }
    }
}
