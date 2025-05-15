using System;

class Program
{
        static void Main()
    {
        /*1. The application receives four numbers and see which one is the highest. The result 
must be returned;*/
        Console.WriteLine("Por favor, digite seu primeiro numero:");
        string input1 = Console.ReadLine();
        int number1 = int.Parse(input1);
        Console.WriteLine("Por favor, digite seu segundo numero:");
        string input2 = Console.ReadLine();
        int number2 = int.Parse(input2);
        Console.WriteLine("Por favor, digite seu terceiro numero:");
        string input3 = Console.ReadLine();
        int number3 = int.Parse(input3);
        Console.WriteLine("Por favor, digite seu quarto numero:");
        string input4 = Console.ReadLine();
        int number4 = int.Parse(input4);

        int maior = number1;
        if (number2 > maior) maior = number2;
        if (number3 > maior) maior = number3;
        if (number4 > maior) maior = number4;
        Console.WriteLine($"O maior numero dentro dos citados é o numero {maior}.");
    }
}
