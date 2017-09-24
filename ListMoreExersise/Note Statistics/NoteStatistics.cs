using System;
using System.Collections.Generic;
using System.Linq;
class NoteStatistics
{
    static void Main()
    {
        List<string> notes = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" }.ToList();
        List<double> freequency = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 }.ToList();

        List<string> totalNotes = new List<string>();
        List<string> naturalNotes = new List<string>();
        List<string> sharpNotes = new List<string>();
        double naturalSum = 0.0;
        double sharpSum = 0;

        double[] inputFreequency = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        for (int i = 0; i < inputFreequency.Length; i++)
        {
            int index = freequency.IndexOf(inputFreequency[i]);
            string currentNotes = notes[index];
            double freequencyCurrent = freequency[index];

            totalNotes.Add(currentNotes);
            if (currentNotes.Length == 1)
            {
                naturalNotes.Add(currentNotes);
                naturalSum += freequencyCurrent;
            }
            else
            {
                sharpNotes.Add(currentNotes);
                sharpSum += freequencyCurrent;
            }
        }
        Console.WriteLine("Notes: " + string.Join(" ", totalNotes));
        Console.WriteLine("Naturals: " + string.Join(", ", naturalNotes));
        Console.WriteLine("Sharps: " + string.Join(", ", sharpNotes));
        Console.WriteLine("Naturals sum: {0:0.##}", naturalSum);
        Console.WriteLine("Sharps sum: {0:0.##}", sharpSum);
    }
}

