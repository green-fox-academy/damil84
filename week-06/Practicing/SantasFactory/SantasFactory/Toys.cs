using System;
using System.Collections.Generic;
using System.Text;

namespace SantasFactory
{
    class Toys
    {
        public string Type { get; set; }
        public int Cost { get; set; }
        public string Owner { get; set; }

        public Toys(string type, int cost)
        {
            Type = type;
            Cost = cost;
        }
    }
}
