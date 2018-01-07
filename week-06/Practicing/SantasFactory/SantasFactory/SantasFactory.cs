using System;
using System.Collections.Generic;
using System.Text;

namespace SantasFactory
{
    class SantasFactory
    {
        public int Balance { get; set; } = 200;

        public Toys Produce(string type, string color)
        {
            Toys doll = new Dolls(type, color);
            Balance -= doll.Cost;
            return doll;
        }

        public Toys Produce(string type, string color, int size)
        {
            Toys ball= new DottedBalls(type, color, size);
            Balance -= ball.Cost;
            return ball;
        }

        public Toys Produce(string type, int lenght)
        {
            Toys rope = new JumpingRopes(type, lenght);
            Balance -= rope.Cost;
            return rope;
        }

        public int GetBalance()
        {
            return Balance;
        }
    }
}
