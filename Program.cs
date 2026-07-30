Console.Clear();

// check if user is online

bool isUserOnline = false;
int age = 25;

// check if user is an adult (18+) AND is online
if (age > 17 && isUserOnline)
{
    Console.WriteLine("user is an adult and is online!");
}
else
{
    Console.WriteLine("user is either under 18 years old or they are offline!");
}