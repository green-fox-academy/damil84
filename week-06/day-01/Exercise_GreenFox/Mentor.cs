using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_GreenFox
{
    class Mentor : Person
    {
        public string Level { get; set; }

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Level = level;
        }

        public Mentor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0} a {1} years old {2} level {3} mentor.", Name, Age, Gender, Level);
        }


    }
}
