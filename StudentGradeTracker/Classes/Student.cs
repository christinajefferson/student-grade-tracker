using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeTracker.Classes
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName 
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public List<int> Grades { get; set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Grades = new List<int>();
        }

        public double GetAverage()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }

            int sum = 0;

            foreach (int grade in Grades)
            {
                sum += grade;
            }

            return (double)sum / Grades.Count;
        }
    }
}