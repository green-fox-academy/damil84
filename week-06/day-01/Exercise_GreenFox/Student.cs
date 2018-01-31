using System;

namespace Exercise_GreenFox
{
    public class Student : Person, ICloneable
    {
        public string PreviousOrganization { get; set; }
        public int SkippedDays { get; set; }

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.PreviousOrganization = previousOrganization;
            this.SkippedDays = 0;
        }

        public Student() : base()
        {
            PreviousOrganization = "The School Of Life";
            SkippedDays = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0} a {1} years old {2} from {3} who skipped {4} days from the course already.", Name, Age, Gender, PreviousOrganization, SkippedDays);
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public int SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
            return SkippedDays;
        }

        public Object Clone()
        {
            var clone = new Student(Name, Age, Gender, PreviousOrganization);
            return clone;
        }
    }
}