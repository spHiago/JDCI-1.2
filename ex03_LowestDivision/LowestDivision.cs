/*The application receives four number then calculates which is the lowest after being 
divided by the remaining. The result must be returned;*/

Console.WriteLine("Welcome, i'll take four numbers, and make a division of each one of them, then" + 
"i will return the lowest result for you.");
Console.WriteLine("For start, tell me your first number:");
string input1 = Console.ReadLine();
float number1 = float.Parse(input1);
Console.WriteLine($"Just for confirm, your first number is {number1}.");
Console.WriteLine("Now, what`s your second number ?");
string input2 = Console.ReadLine();
float number2 = float.Parse(input2);
Console.WriteLine($"And your second number is {number2}.");
Console.WriteLine("Now i need to know your third number:");
string input3 = Console.ReadLine();
float number3 = float.Parse(input3);
Console.WriteLine($"Alrigh, your third number is {number3}, tell me your last number;");
string input4 = Console.ReadLine();
float number4 = float.Parse(input4);
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

return (0);