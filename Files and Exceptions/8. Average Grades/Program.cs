using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _8.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => this.Grades.Average();
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            if (n == 3)
            {
                var lines = File.ReadAllLines("input3.txt");
                var number = Directory.GetFiles(".")
                    .Where(f => f.StartsWith(".\\output"))
                    .Select(f => f.Split('_').Skip(1).FirstOrDefault())
                    .Where(f => f != null)
                    .Select(f => f.Replace(".txt", ""))
                    .Select(int.Parse)
                    .ToList();
            
                int nextNumber = 0;
                if (number.Any())
                {
                    nextNumber = number.Max() + 1;
                }
            
                var outputFileName = "output3_" + nextNumber + ".txt";
            
                var students = new List<Student>();
                //var studentsCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < lines.Length; i++)
                {
                    var tokens = lines[i].Split();
                    var name = tokens[0];
                    var grades = tokens.Skip(1).Select(double.Parse).ToList();
                    var student = new Student()
                    {
                        Name = name,
                        Grades = grades
                    };
                    students.Add(student);
                    students = students.Where(a => a.AverageGrade >= 5.00).OrderBy(a => a.Name)
                        .ThenByDescending(a => a.AverageGrade).ToList();
                }
                foreach (var student in students)
                {
                    var output = $"{student.Name} -> {student.AverageGrade:f2}" + Environment.NewLine;
                    File.AppendAllText(outputFileName, output);
                }
            }
            if (n == 6)
            {
                var lines = File.ReadAllLines("input6.txt");
                var number = Directory.GetFiles(".")
                    .Where(f => f.StartsWith(".\\output"))
                    .Select(f => f.Split('_').Skip(1).FirstOrDefault())
                    .Where(f => f != null)
                    .Select(f => f.Replace(".txt", ""))
                    .Select(int.Parse)
                    .ToList();
            
                int nextNumber = 0;
                if (number.Any())
                {
                    nextNumber = number.Max() + 1;
                }
            
                var outputFileName = "output6_" + nextNumber + ".txt";
            
                var students = new List<Student>();
                //var studentsCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < lines.Length; i++)
                {
                    var tokens = lines[i].Split();
                    var name = tokens[0];
                    var grades = tokens.Skip(1).Select(double.Parse).ToList();
                    var student = new Student()
                    {
                        Name = name,
                        Grades = grades
                    };
                    students.Add(student);
                    students = students.Where(a => a.AverageGrade >= 5.00).OrderBy(a => a.Name)
                        .ThenByDescending(a => a.AverageGrade).ToList();
                }
                foreach (var student in students)
                {
                    var output = $"{student.Name} -> {student.AverageGrade:f2}" + Environment.NewLine;
                    File.AppendAllText(outputFileName, output);
                }
            }           
        }       
    }
}
