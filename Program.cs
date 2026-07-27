// basic greeter app :)
string welcomeMessage = "Welcome, please enter your name.";

// Write welcome message to user
Console.WriteLine(welcomeMessage);

// Read input from console, and store it in a variable
string userName = Console.ReadLine();

// Greet the user by their name
Console.WriteLine("Nice to meet you " + userName);

// Ask user their age
Console.WriteLine("Please enter your age");

var userAge = Console.ReadLine();

// Write to user how old they said they are...

Console.WriteLine("You wrote that you are " + userAge + " years old.");