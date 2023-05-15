// See https://aka.ms/new-console-template for more information


Console.ForegroundColor = ConsoleColor.DarkRed;



Console.Write("Enter in the range of numbers to be used: ");

string range = Console.ReadLine();

int intRange = (int)Convert.ToInt64(range);

Random n = new Random();

int num0 = n.Next(intRange);

int num1 = n.Next(intRange);

int num2 = n.Next(intRange);

int num3 = n.Next(intRange);

Console.WriteLine($"The number generated was {num0}. Do you think the next number is higher or lower? (h/l): ");

string output = Console.ReadLine();

if (output == "H" || output == "h")
{

    if (num1 > num0)
    {
        Console.WriteLine($"You were correct! The number was: {num1}.");
    }
    else { Console.WriteLine($"You were wrong! The number was: {num1}."); }

} else if (output == "L" || output == "l")
{
    if (num1 < num0)
    {
        Console.WriteLine($"You were correct! The number was: {num1}.");
    }
    else { Console.WriteLine($"You were wrong! The number was: {num1}."); }
}

Console.WriteLine("Do you think the next number is higher or lower? (h/l): ");

output = Console.ReadLine();

if (output == "H" || output == "h")
{

    if (num2 > num1)
    {
        Console.WriteLine($"You were correct! The number was: {num2}.");
    }
    else { Console.WriteLine($"You were wrong! The number was: {num2}."); }

}
else if (output == "L" || output == "l")
{
    if (num2 < num1)
    {
        Console.WriteLine($"You were correct! The number was: {num2}.");
    }
    else { Console.WriteLine($"You were wrong! The number was: {num2}."); }
}

Console.WriteLine("Do you think the next number is higher or lower? (h/l): ");

output = Console.ReadLine();

if (output == "H" || output == "h")
{

    if (num3 > num2)
    {
        Console.WriteLine($"You were correct! The number was: {num3}.");
    }
    else { Console.WriteLine($"You were wrong! The number was: {num3}."); }

}
else if (output == "L" || output == "l")
{
    if (num3 < num2)
    {
        Console.WriteLine($"You were correct! The number was: {num3}.");
    }
    else { Console.WriteLine($"You were wrong! The number was: {num3}."); }
}

