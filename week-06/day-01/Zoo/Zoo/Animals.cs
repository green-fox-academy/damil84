using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animals
    {
        protected string name;
        protected int age;
        protected string gender;
        protected bool isHealty;
        protected bool canStayInZoo;

        public abstract void Greet();

        public abstract string WantChild();

        public Animals(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
