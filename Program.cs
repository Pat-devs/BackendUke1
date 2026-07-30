Console.Clear();

// advanced greeret program

// user enters a number between 0-23 (hour of the day)
// then the user will be greeted with:
// Good morning if the hour is between 6 and 11
// Good afternoon if the hour is between 12 and 17
// Good evening if the hour is betweeen 18 and 21
// In all other cases say good night (22,23 og 0,1,2,3,4,5)

Console.WriteLine("Enter a number between 0-23");
// prompt user for input
int hour = int.Parse(Console.ReadLine());

switch (hour)
{
    case >= 6 and <= 11: // && in if is "and" in a switch
        Console.WriteLine("Good morning!");
        break;
    case >= 12 and <= 17:
        Console.WriteLine("Good afternoon!"); 
        break;
    case >= 18 and <= 21:
        Console.WriteLine("Good evening!");
        break;
    case >= 0 and <= 5 or >= 22 and <= 23:
        Console.WriteLine("Good night");
        break;
    default:
        Console.WriteLine("You entered invalid time!");
        break;
}


