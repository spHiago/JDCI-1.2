using System;

class HighestDivision
{
        static void Main()
    {
        /*The application receives two number, then calculates which has the highest result of 
the division of one from the other. The result must be returned;*/
        Console.WriteLine("Now, you have to tell me two numbers.");
        Console.WriteLine("The first number:");
        string input1 = Console.ReadLine();
        int number1 = int.Parse(input1);
        Console.WriteLine($"Right, so your firts number is {number1}.");
        Console.WriteLine("And the second number:");
        string input2 = Console.ReadLine();
        int number2 = int.Parse(input2);
        Console.WriteLine($"Your second number is {number2}.");
        float result1 = number1 / number2;
        float result2 = number2 / number1;
        Console.WriteLine($"The result of the division of the {number1} and the {number2} is {result1}.");
        Console.WriteLine($"And the result of the division of the {number2} and the {number1} is {result2}.");
        float maior = 0;
        if (result1 > result2) maior = result1;
        if (result1 < result2) maior = result2;
        if (result1 == result2) 
            Console.WriteLine($"Os resultados sao iguais.");
        Console.WriteLine($"Knowing that, the highest result of the division is the {maior}.");
    }
}
