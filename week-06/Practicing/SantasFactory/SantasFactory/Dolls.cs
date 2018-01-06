using System;
using System.Collections.Generic;
using System.Text;

namespace SantasFactory
{
    class Dolls : Toys
    {
        public string Color { get; set; }

        public Dolls(string type, string color) : base (type, 25)
        {
            Color = color;
        }
    }
}
