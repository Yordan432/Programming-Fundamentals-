using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }

    public int Age { get; set; }

    public List<int> Grades { get; set; }
}

class JSONStringify
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        string input = Console.ReadLine();

        while (input != "stringify")
        {
            var tokens = input.Split(new char[] { ':' , '-' , '>' , ',' , ' '}, StringSplitOptions.RemoveEmptyEntries);
            var name = tokens[0];
            var age = int.Parse(tokens[1]);
            var grades = tokens.Skip(2).Select(int.Parse).ToList();

            Student student = new Student()
            {
                Name = name,
                Age = age,
                Grades = grades
            };
            students.Add(student);

            input = Console.ReadLine();
        }

        string output = "";

        output += "[";
        for (int i = 0; i < students.Count; i++)
        {
            Student student = students[i];
            output += "{";

            output += "name:\"" + student.Name + "\"" + ",";
            output += "age:" + student.Age + ",";
            output += "grades:[" + string.Join(", ", student.Grades) + "]";

            output += "}";

            if (i < students.Count - 1)
            {
                output += ",";
            }

        }
        output += "]";
        Console.WriteLine(output);
    }
}

