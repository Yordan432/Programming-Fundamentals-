using System;
class Calculator
{
    static void Main()
    {
        int firstOperator = int.Parse(Console.ReadLine());
        char operatorSymbol = char.Parse(Console.ReadLine());
        int lastOperator = int.Parse(Console.ReadLine());

        switch (operatorSymbol)
        {
            case '+':
                int summingUp = firstOperator + lastOperator;
                Console.WriteLine($"{firstOperator} {operatorSymbol} {lastOperator} = {summingUp}");
                break;
            case '-':
                int subtraction = firstOperator - lastOperator;
                Console.WriteLine($"{firstOperator} {operatorSymbol} {lastOperator} = {subtraction}");
                break;
            case '*':
                int multiplication = firstOperator * lastOperator;
                Console.WriteLine($"{firstOperator} {operatorSymbol} {lastOperator} = {multiplication}");
                break;
            case '/':
                int divide = firstOperator / lastOperator;
                Console.WriteLine($"{firstOperator} {operatorSymbol} {lastOperator} = {divide}");

                break;

        }
    }
}

