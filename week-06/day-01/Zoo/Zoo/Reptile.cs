using System;


namespace Zoo
{
    class Reptile : Animals
    {
        public Reptile(string name) : base(name)
        {

        }

        public override void Greet()
        {
            Console.WriteLine("hello reptile");
        }

        public override string WantChild()
        {
            if (name == "Frog")
            {
                return "want a child from an egg/spawn";
            }
            return "want a child from an egg";
        }
    }
}