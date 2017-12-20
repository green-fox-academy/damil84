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
    }
}
