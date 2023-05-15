// See https://aka.ms/new-console-template for more information

int num;
string guess;
int intGuess;

Console.ForegroundColor = ConsoleColor.DarkRed;

Random n = new Random();

num = n.Next(100);

Console.Write("Enter your guess between 1 and 100: ");

guess = Console.ReadLine();

intGuess = (int)Convert.ToInt64(guess);

while (intGuess != num)
{
    if (intGuess < num)
    {
        Console.WriteLine("Too low!");

        Console.Write("Enter your guess between 1 and 100: ");

        guess = Console.ReadLine();

        intGuess = (int)Convert.ToInt64(guess);
    }
    else
    {
        Console.WriteLine("Too high!");

        Console.Write("Enter your guess between 1 and 100: ");

        guess = Console.ReadLine();

        intGuess = (int)Convert.ToInt64(guess);
    }
}

Console.WriteLine("You won!");
