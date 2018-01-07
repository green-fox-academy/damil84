using System;
using System.Collections.Generic;
using System.Text;

namespace SantasFactory
{
    class SantasFactory
    {
        public SantasFactory()
        {

        }

        public Toys Produce(string type, string color)
        {
            Toys doll = new Dolls(type, color);
            return doll;
        }

        internal Toys Produce(string type, string color, int size)
        {
            Toys ball= new DottedBalls(type, color, size);
            return ball;
        }

        public Toys Produce(string type, int lenght)
        {
            Toys rope = new JumpingRopes(type, lenght);
            return rope;
        }
    }
}
