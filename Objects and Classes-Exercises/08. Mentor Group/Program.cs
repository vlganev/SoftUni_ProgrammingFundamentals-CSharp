using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canContinueAttended = true;
            List<Student> studentList = new List<Student>();
            while (canContinueAttended)
            {
                string input = Console.ReadLine();
                if (input == "end of dates")
                {
                    canContinueAttended = false;
                    break;
                }
                string[] tempParse = input.Split(new char[] { ' ' });
                string name = tempParse[0];
                string[] attendedDates = { };
                if (tempParse.Length > 1)
                {
                    attendedDates = tempParse[1].Split(new char[] { ',' });
                }

                
                if (studentList.Any(x => x.Name == name))
                {
                    Student existingStudent = studentList.First(c => c.Name == name);
                    for (int i = 0; i < attendedDates.Length; i++)
                    {
                        DateTime date = DateTime.ParseExact(attendedDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        existingStudent.AttendanceDates.Add(date);
                    }

                }
                else
                {
                    Student student = new Student();
                    student.Name = name;
                    student.AttendanceDates = new List<DateTime>();

                    for (int i = 0; i < attendedDates.Length; i++)
                    {
                        DateTime date = DateTime.ParseExact(attendedDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        student.AttendanceDates.Add(date);
                    }
                    studentList.Add(student);
                }
            }

            bool canContinueComments = true;
            while (canContinueComments)
            {
                string input = Console.ReadLine();
                if (input == "end of comments")
                {
                    canContinueAttended = false;
                    break;
                }

                string[] tempParse = input.Split(new char[] { '-' });
                string name = tempParse[0];
                string comment = tempParse[1];

                if (studentList.Any(x => x.Name == name))
                {
                    Student existingStudent = studentList.First(c => c.Name == name);
                    List<string> newList = new List<string>();
                    newList.Add(comment);
                    existingStudent.Comments.Add(comment);
                }

            }

            foreach (var student in studentList.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                for (int i = 0; i < student.Comments.Count; i++)
                {
                    Console.WriteLine($"- {student.Comments[i]}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.AttendanceDates.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<DateTime> AttendanceDates = new List<DateTime>();
        public List<string> Comments = new List<string>();
    }
}
