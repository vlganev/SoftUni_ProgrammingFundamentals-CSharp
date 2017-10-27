using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            Students[] grades = new Students[inputLines];

            for (int i = 0; i < inputLines; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<double> gradesList = new List<double>();
                for (int j = 1; j < input.Length; j++)
                {
                    gradesList.Add(double.Parse(input[j]));
                }
                grades[i] = new Students() { Name = input[0], Grades = gradesList};
            }

            foreach (Students student in grades.Where(x=> x.AverageGrade >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }


    class Students
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get
            { return Grades.Sum() / Grades.Count; }
        }
    }
}
