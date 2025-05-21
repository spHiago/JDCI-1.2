namespace ex05_ExecuteAplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, which exercise do you want to run?");
            Console.WriteLine("1. ex01_HighestNumber");
            Console.WriteLine("2. ex02_HighestDivision");
            Console.WriteLine("3. ex03_LowestDivision");
            Console.WriteLine("4. ex04_DecimalDivision");
            Console.WriteLine("5. ex05_BizzBuzz");

            string input = Console.ReadLine();
            int exerciseNumber = int.Parse(input);

            switch (exerciseNumber)
            {
                case 1:
                    #region ex01_HighestNumber
                    float number1, number2, number3, number4;
                    string input1, input2, input3, input4;
                    Console.WriteLine("Running ex01_HighestNumber");
                    Console.WriteLine("1. The application receives four numbers and shows which one is the highest.");
                    Console.WriteLine("Please enter the first number:");
                    input1 = Console.ReadLine();
                    number1 = float.Parse(input1);
                    Console.WriteLine("Please enter the second number:");
                    input2 = Console.ReadLine();
                    number2 = float.Parse(input2);
                    Console.WriteLine("Please enter the third number:");
                    input3 = Console.ReadLine();
                    number3 = float.Parse(input3);
                    Console.WriteLine("Please enter the fourth number:");
                    input4 = Console.ReadLine();
                    number4 = float.Parse(input4);

                    float maior = number1;
                    if (number2 > maior) maior = number2;
                    if (number3 > maior) maior = number3;
                    if (number4 > maior) maior = number4;
                    Console.WriteLine($"The highest number is {maior}.");
                    #endregion
                    break;

                case 2:
                    #region ex02_HighestDivision
                    Console.WriteLine("Running ex02_HighestDivision");
                    Console.WriteLine("2. The application receives two numbers and calculates which has the highest result of the division of one by the other.");
                    Console.WriteLine("Please enter the first number:");
                    input1 = Console.ReadLine();
                    number1 = float.Parse(input1);
                    Console.WriteLine("Please enter the second number:");
                    input2 = Console.ReadLine();
                    number2 = float.Parse(input2);

                    float result1 = number1 / number2;
                    float result2 = number2 / number1;
                    Console.WriteLine($"The result of dividing {number1} by {number2} is {result1}.");
                    Console.WriteLine($"The result of dividing {number2} by {number1} is {result2}.");

                    float max = 0;
                    if (result1 > result2) max = result1;
                    if (result1 < result2) max = result2;
                    if (result1 == result2)
                        Console.WriteLine($"Os resultados sao iguais.");
                    Console.WriteLine($"The highest division result is {max}.");
                    #endregion
                    break;

                case 3:
                    #region ex03_LowestDivision
                    Console.WriteLine("Running ex03_LowestDivision");
                    Console.WriteLine("3. The application receives four numbers then calculates which is the lowest after being divided by the remaining. The result must be returned;");
                    Console.WriteLine("Welcome, i'll take four numbers, and make a division of each one of them, then" +
                    "i will return the lowest result for you.");
                    Console.WriteLine("For start, tell me your first number:");
                    input1 = Console.ReadLine();
                    number1 = float.Parse(input1);
                    Console.WriteLine($"Just for confirm, your first number is {number1}.");
                    Console.WriteLine("Now, whats your second number ?");
                    input2 = Console.ReadLine();
                    number2 = float.Parse(input2);
                    Console.WriteLine($"And your second number is {number2}.");
                    Console.WriteLine("Now i need to know your third number:");
                    input3 = Console.ReadLine();
                    number3 = float.Parse(input3);
                    Console.WriteLine($"Alrigh, your third number is {number3}, tell me your last number;");
                    input4 = Console.ReadLine();
                    number4 = float.Parse(input4);
                    Console.WriteLine($"Your fourth number is {number4}.");
                    Console.WriteLine("                                                            ");

                    float division01_01, division01_02, division01_03;
                    float media01;
                    division01_01 = number1 / number2;
                    division01_02 = number1 / number3;
                    division01_03 = number1 / number4;
                    media01 = (division01_01 + division01_02 + division01_03) / 3;

                    Console.WriteLine($"The result of the division using the {number1} is:");
                    Console.WriteLine($"{number1} / {number2} = {division01_01}");
                    Console.WriteLine($"{number1} / {number3} = {division01_02}");
                    Console.WriteLine($"{number1} / {number4} = {division01_03}");
                    Console.WriteLine($"The average of the division using the {number1} is: {media01}");
                    Console.WriteLine("                                                               ");

                    float division02_01, division02_02, division02_03;
                    float media02;
                    division02_01 = number2 / number1;
                    division02_02 = number2 / number3;
                    division02_03 = number2 / number4;
                    media02 = (division02_01 + division02_02 + division02_03) / 3;

                    Console.WriteLine($"The result of the division using the {number2} is:");
                    Console.WriteLine($"{number2} / {number1} = {division02_01}");
                    Console.WriteLine($"{number2} / {number3} = {division02_02}");
                    Console.WriteLine($"{number2} / {number4} = {division02_03}");
                    Console.WriteLine($"The average of the division using the {number2} is: {media02}");
                    Console.WriteLine("                                                               ");

                    float division03_01, division03_02, division03_03;
                    float media03;
                    division03_01 = number3 / number1;
                    division03_02 = number3 / number2;
                    division03_03 = number3 / number4;
                    media03 = (division03_01 + division03_02 + division03_03) / 3;

                    Console.WriteLine($"The result of the division using the {number3} is:");
                    Console.WriteLine($"{number3} / {number1} = {division03_01}");
                    Console.WriteLine($"{number3} / {number2} = {division03_02}");
                    Console.WriteLine($"{number3} / {number4} = {division03_03}");
                    Console.WriteLine($"The average of the division using the {number3} is: {media03}");
                    Console.WriteLine("                                                               ");

                    float division04_01, division04_02, division04_03;
                    float media04;
                    division04_01 = number4 / number1;
                    division04_02 = number4 / number2;
                    division04_03 = number4 / number3;
                    media04 = (division04_01 + division04_02 + division04_03) / 3;

                    Console.WriteLine($"The result of the division using the {number4} is:");
                    Console.WriteLine($"{number4} / {number1} = {division04_01}");
                    Console.WriteLine($"{number4} / {number2} = {division04_02}");
                    Console.WriteLine($"{number4} / {number3} = {division04_03}");
                    Console.WriteLine($"The average of the division using the {number4} is: {media04}");
                    Console.WriteLine("                                                               ");

                    float lowest = 0;
                    if (media01 < media02 && media01 < media03 && media01 < media04)
                        lowest = media01;
                    else if (media02 < media01 && media02 < media03 && media02 < media04)
                        lowest = media02;
                    else if (media03 < media01 && media03 < media02 && media03 < media04)
                        lowest = media03;
                    else if (media04 < media01 && media04 < media02 && media04 < media03)
                        lowest = media04;
                    else if (media01 == media02 && media01 < media03 && media01 < media04)
                        lowest = media01;
                    else if (media01 == media03 && media01 < media02 && media01 < media04)
                        lowest = media01;
                    else if (media01 == media04 && media01 < media02 && media01 < media03)
                        lowest = media01;
                    else if (media02 == media03 && media02 < media01 && media02 < media04)
                        lowest = media02;
                    else if (media02 == media04 && media02 < media01 && media02 < media03)
                        lowest = media02;
                    else if (media03 == media04 && media03 < media01 && media03 < media02)
                        lowest = media03;

                    Console.WriteLine($"The lowest result of the division is: {lowest}");
                    #endregion
                    break;

                case 4:
                    #region ex04_DecimalDivision
                    Console.WriteLine("Running ex04_DecimalDivision");
                    Console.WriteLine("The application receives two number and divides them. The result must be returned, \r\nwith two decimal places");
                    Console.WriteLine("Hello, i will help you with the division of two numbers.");
                    Console.WriteLine("Please, tell me the first number:");
                    input1 = Console.ReadLine();
                    number1 = float.Parse(input1);
                    if (number1 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        break;
                    }

                    Console.WriteLine($"Right, so your first number is {number1}.");

                    Console.WriteLine("Please, tell me the second number:");
                    input2 = Console.ReadLine();
                    number2 = float.Parse(input2);
                    if (number2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        break;
                    }

                    Console.WriteLine($"Right, so your second number is {number2}.");

                    float result = number1 / number2;
                    Console.WriteLine($"The result of the division is: {result:F2}");
                    #endregion
                    break;

                case 5:
                    #region ex05_BizzBuzz
                    Console.WriteLine("Running ex05_BizzBuzz");
                    Console.WriteLine("The application receives two number, calculates the multiplication and return the word" +
                    "“Bizz” when even(par) and “Buzz” when odd(impar)");
                    Console.WriteLine("Hello, i will take two numbers, \nmultiply them, and tell you if the result is even.");
                    Console.WriteLine("So, give me a number please:");
                    input1 = Console.ReadLine();
                    number1 = int.Parse(input1);
                    Console.WriteLine($"So, the first number is the {number1}.");
                    Console.WriteLine("Okay, give me another one:");
                    input2 = Console.ReadLine();
                    number2 = int.Parse(input2);
                    Console.WriteLine($"You choice the number {number2}.");
                    result = number1 * number2;
                    Console.WriteLine($"The result of this operation is {result}.");

                    if (result % 2 == 0)
                    {
                        Console.Write($"And we all know that {result} is a even number.");
                    }
                    else
                    {
                        Console.Write($"And we all know that {result} is a odd number.");
                        #endregion
                    }
                    break;
            }
        }
    }
}