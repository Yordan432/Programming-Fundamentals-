using System;
namespace Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            BasicsMethod();
        }
        static void BasicsMethod()
        {
            int n = int.Parse(Console.ReadLine());
            var operation = Console.ReadLine();
            ShowSuccess(operation, " ");
            var operation2 = Console.ReadLine();          
            ShowError(operation2, n);
        }
        static void ShowSuccess(string operatorion, string message)
        {
            if (operatorion == "success")
            {
                string operationOne = Console.ReadLine();
                string operationTow = Console.ReadLine();

              //  ShowSuccess(operationOne, operationTow);
                string message1 = $"Successfully executed {operationOne}.";
                Console.WriteLine(message1);
                Console.WriteLine("==============================");

                Console.Write($"Message: {operationTow}.");
                Console.WriteLine();
            }
        }
        static void ShowError(string operation, int code)
        {
            if (operation == "error")
            {
                string operation1 = Console.ReadLine();
                var n = int.Parse(Console.ReadLine());
                bool isNegativeNumber = n < 0;
                string message = "";
                if (isNegativeNumber)
                {
                    message = "Internal System Failure";
                }
                else
                {
                    message = "Invalid Client Data";
                }

                Console.WriteLine($"Error: Failed to execute {operation1}.");
                Console.WriteLine("==============================");
                Console.WriteLine($"Error Code: {n}.");
                Console.WriteLine($"Reason: {message}.");
            }
        }
    }
}
