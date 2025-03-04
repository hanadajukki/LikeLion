using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = new int[25];
            
            int input=0;
            int iBingo = 0;
            int iCount = 0;

            ////스왑
            //int a = 10;
            //int b = 20;
            //int t = 0;

            //t = a;
            //a = b;
            //b = t;

            //Console.Write("a :" + a + " b : " + b);


            for (int i = 0; i < 25; i++)
            {
                iArray[i] = i + 1;
            }



            Random rand = new Random();

            //셔플
            for (int i = 0; i < 100; i++)
            {
                int iA = rand.Next(0, 25);
                int iB = rand.Next(0, 25);
                int iT = 0;

                iT = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = iT;

            }

            while (true)
            {
                
                //빙고판
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)

                    {
                        if (iArray[i * 5 + j] == 0)

                            Console.Write(" *");

                        else
                            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                    }
                    Console.WriteLine();
                   
                }
                Console.WriteLine("빙고숫자: " + iBingo);

                Console.WriteLine("숫자를 입력하세요.");
                input = int.Parse(Console.ReadLine());
                iBingo = 0;
                for (int i = 0; i < 25; i++)
                {
                    if (iArray[i] == input)
                    {
                        iArray[i] = 0;
                        break;
                    }
                }

                //빙코 체크 로직
                //가로 체크
                for(int i=0; i<5;i++)
                {
                    for(int j=0;j<5;j++)
                    {
                        if (iArray[i*5+j]==0)
                        {
                            ++iCount;
                        }

                        if(iCount ==5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }



                //세로 체크
                for(int i=0;i<5;i++)
                {
                    for(int j=0;j<5;j++)
                    {
                        if (iArray[i+5*j]==0)
                        {
                            ++iCount;
                        }

                        if(iCount==5)
                        {
                            ++iBingo;
                        }
                        
                    }
                    iCount = 0;
                }

                //대각선 오른쪽체크
                //00 01 02 03 04
                //05 06 07 08 09
                //10 11 12 13 14
                //15 16 17 18 19
                //20 21 22 23 24

                for(int i=0;i<5;i++)
                {
                    if (iArray[i*4+4] ==0)
                    {
                        ++iCount;
                    }
                    if(iCount==5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;
                //대각선 왼쪽체크

                for(int i=0;i<5;i++)
                {
                        
                }
            }
        }
    }
}
