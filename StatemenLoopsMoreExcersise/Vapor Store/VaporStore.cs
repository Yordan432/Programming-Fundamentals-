using System;

class VaporStore
{
    static void Main()
    {
        double OutFall4 = 39.99;
        double CSOG = 15.99;
        double ZplinterZell = 19.99;
        double Honored2 = 59.99;
        double RoverWatch = 29.99;
        double RoverWatchOriginsEdition = 39.99;
        string empty = String.Empty;

        string OutFall = "OutFall 4";
        string CSOGString = "CS: OG";
        string ZplinterZellString = "Zplinter Zell";
        string Honored2String = "Honored 2";
        string RoverWatchString = "RoverWatch";
        string RoverWatchOriginsEditionString = "RoverWatch Origins Edition";
        
        double balance = double.Parse(Console.ReadLine());

        string input = Console.ReadLine();
        while (input != "Game Time")
        {
            double price = 0;
            if (input == "OutFall 4")
            {
                price = OutFall4;
                Console.WriteLine("Bought {0}" , OutFall);           
            }
            else if(input == "CS: OG")
            {
                price = CSOG;
                Console.WriteLine("Bought {0}", CSOGString);

            }
            else if (input == "Zplinter Zell")
            {
                
                price = ZplinterZell;
                Console.WriteLine("Bought {0}", ZplinterZellString);

            }
            else if (input == "Honored 2")
            {         
                price = Honored2;
                Console.WriteLine("Bought {0}",  Honored2String);
                
            }
            else if (input == "RoverWatch")
            {
                price = RoverWatch;
                Console.WriteLine("Bought {0}",  RoverWatchString);


            }
            else if (input == "RoverWatch Origins Edition")
            {
                price = RoverWatchOriginsEdition;
                Console.WriteLine("Bought {0}",  RoverWatchOriginsEditionString);
            }
            else if(input != "RoverWatch Origins Edition" || input != "RoverWatch" || input != "Honored 2" || input != "CS: OG" || input != "OutFall 4" || input != "Zplinter Zell")
            {
                Console.WriteLine("Not Found");
            }
            balance -= price;
            if (balance <= price)
            {
                Console.WriteLine("Too Expensive");
                return;
            }

            input = Console.ReadLine();

            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            
        }
    }
}