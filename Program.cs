// Declare variables and then initialize to zero
double num1 = 0;
double num2 = 0;

// Display title as the C# console calculator app
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number
Console.WriteLine("Type a number, and then press <Enter>");
num1 = Convert.ToDouble(Console.ReadLine());

// Ask the user to type the second number
Console.WriteLine("Type another number, and then press <Enter>");
num2 = Convert.ToDouble(Console.ReadLine());

// Ask the user to choose an option
Console.WriteLine("Choose an option from the followin list:");
Console.WriteLine("\t[a] - Add");
Console.WriteLine("\t[s] - Subtract");
Console.WriteLine("\t[m] - Multiply");
Console.WriteLine("\t[d] - Divide");
Console.Write("Your option? ");

// Use a switch statement to do the math
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} x {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} : {num2} = " + (num1 / num2));
        break;
}

// Wait for the user to respond before closing
Console.Write("Press any key to close the Calculator console app...\n");
Console.ReadKey();
