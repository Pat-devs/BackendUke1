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

// 1. check if user entered a number between 0-23
if (hour >= 0 && hour <= 23)
{
    // check if its morning?
    if (hour >= 6 && hour <= 11)
    {
        Console.WriteLine("Good morning!");
    }
    else if (hour <= 17) // since we already know the hour is above 12 (due to hour <= 11 in the above if) we can just check if the hour is below/equal to 17
    {
        Console.WriteLine("Good afternoon!");
    }
    else if (hour <= 21)
    {
        Console.WriteLine("Good evening!");
    }
    else // we can safely assume her that the hour is above 21 and below 6
    {
        Console.WriteLine("Good night");
    }

}
else
{
    Console.WriteLine("You entered invalid time!");
}
