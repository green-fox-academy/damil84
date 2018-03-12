using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
    class Computer
    {
        protected string _name = "Unknown";
        public string Name { get
            {
                return _name;
            }
                private set
            {
                _name = value;
            }
        }
        public Computer(string Name)
        {
            this.Name = Name;
        }
    }
}
