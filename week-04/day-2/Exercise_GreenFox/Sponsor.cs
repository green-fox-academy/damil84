using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_GreenFox
{
    class Sponsor : Person
    {
        public string company;
        public int hiredStudents;

        public Sponsor(string name, int age, string gender, string company)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.company = company;
            hiredStudents = 0;
        }

        public Sponsor()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            company = "Google";
            hiredStudents = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0} a {1} years old {2} vho represents {3} and hired {4} students so far.", name, age, gender, company, hiredStudents);
        }

        public int Hire()
        {
            hiredStudents++;
            return hiredStudents;
        }






    }
}
