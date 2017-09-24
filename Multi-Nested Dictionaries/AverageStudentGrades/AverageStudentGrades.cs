using System;
using System.Collections.Generic;
using System.Linq;
class AverageStudentGrades
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());

        Dictionary<string, List<double>> gradesStudents = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            string[] students = Console.ReadLine().Split(' ');

            var keyName = students[0];
            var valueGrade = students[1];


            if (!gradesStudents.ContainsKey(keyName))
            {
                gradesStudents[keyName] = new List<double>();
            }
            gradesStudents[keyName].Add(double.Parse(valueGrade));
        }

        foreach (var pairs in gradesStudents)
        {
            Console.Write("{0} -> " ,pairs.Key);
            foreach (var item in pairs.Value)
            {
                Console.Write("{0:f2} ", item);
            }
            var average = pairs.Value.Average();
            Console.WriteLine("(avg: {0:f2}) " , average);
        }
    }
}

