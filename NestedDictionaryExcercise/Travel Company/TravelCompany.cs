using System;
using System.Collections.Generic;
using System.Linq;
class TravelCompany
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ':', ',', '-' });

        while (input[0] != "ready")
        {
            var city = input[0];
            var typeVehicles = input[1];
            var capacity = input[2];
            var typeDrive = input[3];
            var capacityDrive = input[4];
            var typeRun = input[5];
            var capacityRun = input[6];



            input = Console.ReadLine().Split(new char[] { ':', ',', '-' });
        }
    }
}

