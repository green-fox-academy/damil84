using System;

namespace Zoo
{
    class Bird : Animals
    {
        public Bird(string name) : base(name)
        {

        } 

        public override void Greet()
        {
            Console.WriteLine("hello birdy");
        }

        public override string WantChild()
        {
            return "want a child from an egg";
        }
    }
}