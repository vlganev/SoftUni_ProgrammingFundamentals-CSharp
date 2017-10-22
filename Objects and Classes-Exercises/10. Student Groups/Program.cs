using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }
    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
