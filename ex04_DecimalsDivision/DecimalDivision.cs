/*The application receives two number and divides them. The result must be returned, 
with two decimal places; */

Console.WriteLine("Hello, i will help you with the division of two numbers.");
Console.WriteLine("Please, tell me the first number:");
string input1 = Console.ReadLine();
double number1 = double.Parse(input1);
Console.WriteLine($"Right, so your first number is {number1}.");

Console.WriteLine("Please, tell me the second number:");
string input2 = Console.ReadLine();
double number2 = double.Parse(input2);
Console.WriteLine($"Right, so your second number is {number2}.");

double result = number1 / number2;
Console.WriteLine($"The result of the division is: {result:F2}");
