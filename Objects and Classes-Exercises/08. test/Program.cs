using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class Program
{
    static void Main()
    {
        List<Student> students = ReadStudentsDates();
        AddStudentsComments(students);
        students = students.OrderBy(s => s.Name).ToList();
        SortStudentsByDate(students);
        SortStudentsData(students);
        PrintReport(students);
    }

    static List<Student> ReadStudentsDates()
    {
        List<Student> students = new List<Student>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end of dates")
            {
                break;
            }
            string[] splitInput = input.Split();
            string name = splitInput[0];
            if (splitInput.Length == 1)
            {
                if (!students.Any(a => a.Name == name))
                {
                    Student newStudent = new Student
                    {
                        Name = name
                    };
                    students.Add(newStudent);
                }
                continue;
            }
            List<DateTime> dates = splitInput[1].
                Split(',').
                Select(d => DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture)).
                ToList();
            if (students.Any(a => a.Name == name))
            {
                Student exitingStudent = students.First(a => a.Name == name);
                exitingStudent.Dates = exitingStudent.Dates.Concat(dates).ToList();
            }
            else
            {
                Student newStudent = new Student
                {
                    Name = name,
                    Dates = dates,
                };
                students.Add(newStudent);
            }
        }
        return students;
    }

    static void AddStudentsComments(List<Student> students)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end of comments")
            {
                break;
            }
            string[] splitInput = input.Split('-');
            string name = splitInput[0];
            if (!students.Any(a => a.Name == name))
            {
                continue;
            }
            string[] comments = splitInput.Skip(1).ToArray();
            Student exitingStudent = students.First(a => a.Name == name);
            if (exitingStudent.Comments == null)
            {
                exitingStudent.Comments = new List<string>();
            }
            foreach (string comment in comments)
            {
                exitingStudent.Comments.Add(comment);
            }
        }
    }


    static void SortStudentsByDate(List<Student> students)
    {
        foreach (Student student in students)
        {
            if (student.Dates != null)
            {
                student.Dates.Sort();
            }
        }
    }

    static void SortStudentsData(List<Student> students)
    {
        foreach (Student student in students)
        {
            if (student.Dates != null)
            {
                student.Dates.OrderBy(a => a);
            }
            if (student.Comments != null)
            {
                student.Comments.OrderBy(a => a);
            }
        }
    }

    static void PrintReport(List<Student> students)
    {
        foreach (Student student in students.OrderBy(s => s.Name))
        {
            Console.WriteLine(student.Name);
            Console.WriteLine("Comments:");
            if (student.Comments != null)
            {
                foreach (string comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
            }
            Console.WriteLine("Dates attended:");
            if (student.Dates != null)
            {
                foreach (DateTime date in student.Dates)
                {
                    Console.WriteLine($"-- {date.Date:dd/MM/yyyy}");
                }
            }
        }
    }
}

class Student
{
    public string Name { get; set; }
    public List<DateTime> Dates { get; set; }
    public List<string> Comments { get; set; }
}