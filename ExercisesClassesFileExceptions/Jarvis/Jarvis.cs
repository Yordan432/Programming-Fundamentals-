using System;
using System.Collections.Generic;

class Arms
{
    public int Energy { get; set; }

    public int Distance { get; set; }

    public int CountFingers { get; set; }
}

class Legs
{
    public int Energy { get; set; }

    public int Strength { get; set; }

    public int Speed { get; set; }

}

class Torso
{
    public int Energy { get; set; }

    public double ProcessorSizeCentimeters { get; set; }

    public string HousingMaterial { get; set; }
}

class Head
{
    public int Energy { get; set; }

    public int IQ { get; set; }

    public string SkinMaterial { get; set; }
}

class Jarvis
{
    static void Main()
    {
        int maxEnergyRobot = int.Parse(Console.ReadLine());

        string input = Console.ReadLine();

        while (input != "Assemble!")
        {

            input = Console.ReadLine();
        }
    }
}

