using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOO
{
    class Counter
    {
        public static int dbCounter;
        static Counter()
        {
            dbCounter = 0;
        }
        public Counter()
        {
            dbCounter++;
        }
    }
}
