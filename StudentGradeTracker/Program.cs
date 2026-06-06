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
                ShowHeader();

                Console.WriteLine("**** - Student Grade Tracker - ****");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Grade to Student");
                Console.WriteLine("3. View Students");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter first name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine();

                    students.Add(new Student(firstName, lastName));

                    Console.WriteLine($"Student {firstName} {lastName} added!");
                    Console.WriteLine("Press ENTER to continue...");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    Console.Write("Enter first name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine();

                    Student foundStudent = null;

                    foreach (Student s in students)
                    {
                        if (s.FirstName.Equals(firstName) && s.LastName.Equals(lastName))
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
                        Console.WriteLine("Press ENTER to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                        Console.WriteLine("Press ENTER to continue...");
                        Console.ReadLine();
                    }
                }
                else if (choice == "3")
                {
                    ShowHeader();

                    Console.WriteLine("**** - Student List - ****");
                    Console.WriteLine();

                    if (students.Count == 0)
                    {
                        Console.WriteLine("No students found.");
                    } 
                    else
                    {
                        foreach (Student s in students)
                        {
                            Console.WriteLine($"Name: {s.FullName}");

                            if (s.Grades.Count == 0)
                            {
                                Console.WriteLine("Grades: None");
                            }
                            else
                            {
                                Console.WriteLine("Grades: " + string.Join(", ", s.Grades));
                                Console.WriteLine($"Average: {s.GetAverage():F2}");
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Press ENTER To Continue...");
                        Console.ReadLine();
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

        static void ShowHeader()
        {
            Console.Clear();
            Console.WriteLine("Student Grade Tracker");
            Console.WriteLine();
        }
    }
}