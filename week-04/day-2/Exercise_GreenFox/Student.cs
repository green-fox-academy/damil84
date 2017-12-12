using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_GreenFox
{
    class Student : Person
    {
        public string previousOrganization { get; set; }
        public int skippedDays { get; set; }

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }

        public Student()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            previousOrganization = "The School Of Life";
            skippedDays = 0;

        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0} a {1} years old {2} from {3} who skipped {4} days from the course already.", name, age, gender, previousOrganization, skippedDays);
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public int SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
            return skippedDays;
        }

        
    }
}
