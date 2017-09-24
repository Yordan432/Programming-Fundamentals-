using System;
using System.Collections.Generic;
using System.Linq;
class Student
{
    public string Name { get; set; }

    public int Age { get; set; }

    public List<int> Grades { get; set; }
}
class JSONParse
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        string[] input = Console.ReadLine().Split(new string[] { "[", "{", ":", "\"", ",", "]", "}", "age:" , "grades:[" }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, Dictionary<int, List<int>>> date = new Dictionary<string, Dictionary<int, List<int>>>();

        var count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[count] == "name")
            {
                
            }
        }


    }
}

