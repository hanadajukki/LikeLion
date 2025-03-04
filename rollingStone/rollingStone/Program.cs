using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace rollingStone
{
    class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int playerX;
        public int playerY;
        bool pushStatus;

        public Stone stone =new Stone();


        public Player ()
        {
            playerX = 0;
            playerY = 12;
            pushStatus = false;

        }
        public void move()
        {
            int pressKey;

            if(Console.KeyAvailable)
            {
                pressKey = _getch();

                switch (pressKey)
                {
                    case 72:
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;

                    case 75:
                        playerX--;
                        if (playerX <0)
                            playerX =0;
                        break;

                    case 77:
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;

                    case 80:
                        playerY++;
                        if (playerY > 21)
                            playerX = 21;
                        break;
                }

            }
        }

        public void GameMain()
        {
            Console.Clear();
            move();
            playerDraw();
          


        }

        public void playerDraw()
        {
            string pl = "+";

            Console.SetCursorPosition(playerX, playerY);

            Console.WriteLine(pl);
        }

        
    }

    class Stone
    {
        public int stoneX;
        public int stoneY;
        

        public Stone()
        {
            stoneX = 10;
            stoneY = 12;

        }

        public void stoneDraw()
        {
            string stone = "@";
            Console.SetCursorPosition(stoneX, stoneY);
            Console.WriteLine(stone);
            //Console.Clear();
        }

        public void move(int x, int y)
        {
            if ((stoneX == x ) && ( stoneY - 1 == y))
            {
                stoneY+=1;

            }
            else if((stoneX == x) && (stoneY+1 == y))
            {
                stoneY-=1;
            }
            else if((stoneY == y) && (stoneX-1 ==x))
            {
                stoneX+=1;
            }
            else if((stoneY ==y) && (stoneX+1 == x))
            {
                stoneX=1;
            }
        }
    }

    class Ground
    {
        public int x, y;
        public bool blockStatus;
        public string type;


        public Ground()
        {
            //bool blockStatus=false;
            //string Type;

        }

        public void groundDraw()
        {
            
        }

        

        public void gameClear()
        {
            Console.Clear();
            Console.WriteLine("게임 클리어");
        }
    }

    class goal
    {
        public int goalX, goalY;

        public goal()
        {
            goalX = 15; 
            goalY=12;
        }

        public void gameClear(int x, int y)
        {


            if((x==goalX)&&(y==goalY))
            {
                Console.Clear();
                Console.WriteLine("게임 클리어");
            }
        }

        public void goalPrint()
        {
            Console.SetCursorPosition(goalX, goalY);
            Console.WriteLine("○");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80,25);

            Player pl = new Player();
            Stone stone = new Stone();
            Ground ground = new Ground();
            goal target = new goal();

            int dwtTime = Environment.TickCount;

            while(true)
            {
                if(dwtTime+50 < Environment.TickCount)
                {
                    dwtTime = Environment.TickCount;
                    Console.Clear();

                    pl.GameMain();


                    stone.stoneDraw();
                    stone.move(pl.playerX,pl.playerY);


                    target.goalPrint();
                    target.gameClear(stone.stoneX,stone.stoneY);

                    
                }
            }
        }
    }
}
