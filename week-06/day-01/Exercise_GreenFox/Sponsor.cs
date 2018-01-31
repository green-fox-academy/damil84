using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_GreenFox
{
    class Sponsor : Person
    {
        public string Company;
        public int HiredStudents;

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.Company = company;
            HiredStudents = 0;
        }

        public Sponsor()
        {
            Company = "Google";
            HiredStudents = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0} a {1} years old {2} vho represents {3} and hired {4} students so far.", Name, Age, Gender, Company, HiredStudents);
        }

        public int Hire()
        {
            HiredStudents++;
            return HiredStudents;
        }
    }
}