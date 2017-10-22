using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\";
            if (File.Exists(path + "output.txt"))
                File.Delete(path + "output.txt");

            using (StreamReader reader = new StreamReader(path + "input.txt", Encoding.GetEncoding("UTF-8")))
            {
                string line = "x";
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line)) break;
                    int inputLines = int.Parse(line);
                    Students[] grades = new Students[inputLines];

                    for (int i = 0; i < inputLines; i++)
                    {
                        string nextLine = reader.ReadLine();
                        string[] input = nextLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        List<double> gradesList = new List<double>();
                        for (int j = 1; j < input.Length; j++)
                        {
                            gradesList.Add(double.Parse(input[j]));
                        }
                        grades[i] = new Students() { Name = input[0], Grades = gradesList };
                    }
                    using (StreamWriter writer = new StreamWriter(path + "output.txt", append: true))
                    {
                        foreach (Students student in grades.Where(x => x.AverageGrade >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
                        {
                            writer.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
                        }
                        writer.WriteLine();
                    }
                }
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
