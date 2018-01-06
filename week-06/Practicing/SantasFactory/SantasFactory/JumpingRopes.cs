using System;
using System.Collections.Generic;
using System.Text;

namespace SantasFactory
{
    class JumpingRopes : Toys
    {
        public int Length { get; set; }

        public JumpingRopes(string type, int lenght) : base(type, 15)
        {
            Length = lenght;
        }

    }
}
