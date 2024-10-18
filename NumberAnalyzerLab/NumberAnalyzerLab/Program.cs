
string userAnswer = "y";
Console.WriteLine("Hello, what is your name?");
string userName = Console.ReadLine();

Console.WriteLine($"Hello {userName}, Please enter an integer between 1 and 100 inclusive");

while (userAnswer.ToLower() == "y")
{

    string stringUserNumber = Console.ReadLine();

    int intUserNumber;
    bool successIntParse;
    successIntParse = int.TryParse(stringUserNumber, out intUserNumber);

    if (successIntParse == false || intUserNumber <= 1 || intUserNumber >= 100)
    {
        Console.WriteLine($"{userName} entered an invalid number!");
        break;
    }

    if (intUserNumber % 2 == 1 && intUserNumber < 60)
    {
        Console.WriteLine($"{intUserNumber} is odd and less then 60");
    }
    else if (intUserNumber % 2 == 0 && intUserNumber >=2 &&  intUserNumber <= 24)
    {
        Console.WriteLine($"{intUserNumber} is even and less than 25");
    }
    else if (intUserNumber % 2 == 0 && intUserNumber >=26 &&  intUserNumber <= 60)
    {
        Console.WriteLine($"{intUserNumber} is even and between 26 and 60 inclusive");
    }
    else if (intUserNumber % 2 == 0 && intUserNumber > 60)
    {
        Console.WriteLine($"{intUserNumber} is even and greater than 60");
    }
    else
    {
        Console.WriteLine($"{intUserNumber} is odd and greater 60");
    }

    Console.WriteLine("Would you like to enter another number? (y/n)");
    userAnswer = Console.ReadLine();
    
    while(userAnswer.ToLower() != "y" && userAnswer.ToLower() != "n")
    {
        Console.WriteLine("Please enter a valid responce");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer.ToLower() == "y")
    {
        Console.WriteLine("Please enter another number");
    }

}
if (userAnswer.ToLower() == "n")
{
    Console.WriteLine("Goodbye!");
}


