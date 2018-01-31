using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_GreenFox
{
    class PallidaClass
    {
        public string className { get; set; }
        List<Student> students = new List<Student>();
        List<Mentor> mentors = new List<Mentor>();
        

        public PallidaClass(string classname)
        {
            this.className = classname;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }
        public void Info()
        {
            Console.WriteLine("Pallida " + className + " class has " + students.Count + " students and " + mentors.Count + " mentors.");
        }

    }
}
