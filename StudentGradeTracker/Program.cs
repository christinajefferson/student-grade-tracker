using System;
using System.Collections.Generic;
using StudentGradeTracker.Classes;

namespace StudentGradeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("**** - Student Grade Tracker - ****");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Grade to Student");
                Console.WriteLine("3. View Students");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();

                    students.Add(new Student(name));

                    Console.WriteLine("Student added!");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();

                    Student foundStudent = null;

                    foreach (Student s in students)
                    {
                        if (s.Name == name)
                        {
                            foundStudent = s;
                            break;
                        }
                    }

                    if (foundStudent != null)
                    {
                        Console.Write("Enter grade: ");
                        string input = Console.ReadLine();
                        int grade = Convert.ToInt32(input);

                        foundStudent.Grades.Add(grade);

                        Console.WriteLine("Grade added!");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("**** - Student List - ****");

                    foreach (Student s in students)
                    {
                        Console.WriteLine($"{s.Name} - Average: {s.GetAverage():F2}");
                    }
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }
    }
}