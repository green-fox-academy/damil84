using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greenfox;

namespace RPG_Game
{
    class map
    {
        public static Random randomNumberGenerator = new Random();
        public int MapWidth { get; private set; }
        public int MapHeigth { get; private set; }
        public FoxDraw myfoxDraw { get; set; }
        public List<int> tilelist;

        public Map(FoxDraw foxDraw)
        {
            MapWidth = 10;
            MapHeigth = 10;
            myfoxDraw = foxDraw;
        }

        public void MapCreater()
        {
            tilelist = new List<int> { 0, 1, 0, 0, 0, 1, 0, 0, 0, 0,
                                           0, 1, 0, 1, 0, 1, 0, 1, 1, 0,
                                           0, 1, 0, 1, 0, 1, 0, 1, 0, 0,
                                           0, 1, 0, 1, 0, 1, 0, 1, 0, 1,
                                           0, 1, 0, 1, 0, 1, 0, 1, 0, 0,
                                           0, 1, 0, 1 ,0, 1, 0, 1, 1, 0,
                                           0, 1, 0, 1, 0, 1, 0, 1, 0, 0,
                                           0, 1, 0, 1, 0, 1, 0, 1, 0, 1,
                                           0, 1, 0, 1, 0, 1, 0, 1, 0, 0,
                                           0, 0, 0, 1, 0, 0, 0, 1, 1, 0,};
            int ycoordinate = 0;
            int listcounter = 0;
            for (int i = 0; i < MapHeigth; i++)
            {
                int xcoordinate = 0;

                for (int j = 0; j < MapWidth; j++)
                {
                    if (tilelist[listcounter] == 0)
                    {
                        int randomNumber = randomNumberGenerator.Next(1, 11);

                        if (randomNumber == 1)
                        {
                            myfoxDraw.AddImage("Assets/floor1.png", xcoordinate, ycoordinate);
                            xcoordinate = xcoordinate + 50;
                        }

                        else if (randomNumber == 2)
                        {
                            myfoxDraw.AddImage("Assets/floor2.png", xcoordinate, ycoordinate);
                            xcoordinate = xcoordinate + 50;
                        }

                        else if (randomNumber == 3)
                        {
                            myfoxDraw.AddImage("Assets/floor3.png", xcoordinate, ycoordinate);
                            xcoordinate = xcoordinate + 50;
                        }

                        else if (randomNumber == 4)
                        {
                            myfoxDraw.AddImage("Assets/floor4.png", xcoordinate, ycoordinate);
                            xcoordinate = xcoordinate + 50;
                        }

                        else if (randomNumber == 5)
                        {
                            myfoxDraw.AddImage("Assets/floor5.png", xcoordinate, ycoordinate);
                            xcoordinate = xcoordinate + 50;
                        }

                        else if (randomNumber == 6)
                        {
                            myfoxDraw.AddImage("Assets/floor6.png", xcoordinate, ycoordinate);
                            xcoordinate = xcoordinate + 50;
                        }

                        else if (randomNumber == 7)
                        {
                            myfoxDraw.AddImage("Assets/floor7.png", xcoordinate, ycoordinate);
                            xcoordinate = xcoordinate + 50;
                        }

                        else if (randomNumber == 8)
                        {
                            myfoxDraw.AddImage("Assets/floor8.png", xcoordinate, ycoordinate);
                            xcoordinate = xcoordinate + 50;
                        }

                        else if (randomNumber == 9)
                        {
                            myfoxDraw.AddImage("Assets/floor9.png", xcoordinate, ycoordinate);
                            xcoordinate = xcoordinate + 50;
                        }

                        else if (randomNumber == 10)
                        {
                            myfoxDraw.AddImage("Assets/floor10.png", xcoordinate, ycoordinate);
                            xcoordinate = xcoordinate + 50;
                        }

                    }
                    if (tilelist[listcounter] == 1)
                    {
                        myfoxDraw.AddImage("Assets/wall2.png", xcoordinate, ycoordinate);
                        xcoordinate = xcoordinate + 50;
                    }
                    listcounter++;
                }
                ycoordinate = ycoordinate + 50;
            }
        }

    }
}
