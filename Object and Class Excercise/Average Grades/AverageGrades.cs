using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double Average => this.Grades.Average();
}

class AverageGrades
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Student> grades = new List<Student>();


        List<string> names = new List<string>();
        List<double> gradesStudents = new List<double>();
        var namesStudents = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ');
            var takaName = input.First();

            var takeGrades = input.Skip(1).Select(double.Parse).ToList();

            Student student = new Student()
            {
                Name = takaName,
                Grades = takeGrades
            };

            grades.Add(student);
            //    var input = Console.ReadLine().Split(' ');
            //    var name = input[0];
            //    student.Name = name;
            //    student.Grades = new List<double>();
            //    for (int j = 1; j < input.Length; j++)
            //    {
            //        var gradesStudent = double.Parse(input[j]);

            //        student.Grades.Add(gradesStudent);
            //    }
            //    var average = student.Grades.Average();
            //    if (average >= 5.00)
            //    {
            //        names.Add(name);
            //        var currentAverage = student.Grades.Average();
            //        gradesStudents.Add(currentAverage);
            //    }
            //}
            //names = names.OrderBy(x => x).ToList();
            //gradesStudents = gradesStudents.OrderByDescending(x => x).ToList();
            //for (int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine($"{names[i]} -> {gradesStudents[i]:f2}");
            //}
        }
        grades =grades.Where(gr => gr.Grades.Average() >= 5.00)
               .OrderBy(x => x.Name).ThenByDescending(g => g.Average).ToList();

        foreach (var item in grades)
        {
            Console.WriteLine($"{item.Name} -> {item.Average:f2}");
        }
        //private static List<string> OrderByAndPrint(List<string> names, string name, double average)
        //{

        //    names = names.OrderBy(x => x).ToList();
        //    Console.WriteLine($"{name} -> {average}");
        //    return names;
        //}
    }
}
