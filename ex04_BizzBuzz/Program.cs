using System;

class Program
{
    static void Main()
    {
        /* . The application receives two number, calculates the multiplication and return the word
    “Bizz” when even (par) and “Buzz” when odd (impar); */

        Console.WriteLine("Hello, i will take two numbers, \nmultiply them, and tell you if the result is even.");
        Console.WriteLine("So, give me a number please:");
        string input1 = Console.ReadLine();
        int number1 = int.Parse(input1);
        Console.WriteLine($"So, the first number is the {number1}.");
        Console.WriteLine("Okay, give me another one:");
        string input2 = Console.ReadLine();
        int number2 = int.Parse(input2);
        Console.WriteLine($"You choice the number {number2}.");
        int result = number1 * number2;
        Console.WriteLine($"The result of this operation is {result}.");

        if (result % 2 == 0)
        {
            Console.Write($"And we all know that {result} is a even number.");
        }
        else 
        {
            Console.Write($"And we all know that {result} is a odd number.");
        }
    }
}