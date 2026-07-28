// super simplified calculator
// features: can receive two numbers
// 

Console.Clear();
Console.WriteLine("Welcome to super simple calculator!");

Console.WriteLine("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

// Show the numbers as a sum equation, and the result
int sumResult = firstNumber + secondNumber;

Console.WriteLine(firstNumber + " + " + secondNumber + " = " + firstNumber + secondNumber);

Console.WriteLine($"{firstNumber} + {secondNumber} = {sumResult}");       