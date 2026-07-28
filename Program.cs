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

// read the input, and parse it into an integer
int userAge = int.Parse(Console.ReadLine()); 

// Write to the user how old they will be in one year time from now

// int ageAfter20years = userAge + 20;
userAge++; // userAge += 1; // userAge = userAge + 1;

Console.WriteLine("Next year, you will be " + userAge + " years old.");