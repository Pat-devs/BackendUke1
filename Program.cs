// super simplified calculator
// features: can receive two numbers, and show:
// sum, substraction, multiplication and division.

Console.Clear();
Console.WriteLine("Welcome to super simple calculator!");

Console.WriteLine("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

// Show the numbers as a sum equation, and the result
int sumResult = firstNumber + secondNumber;

Console.WriteLine($"{firstNumber} + {secondNumber} = {sumResult}");       

// Show the numbers as a substraction equation, and the result
int subResult = firstNumber - secondNumber;

Console.WriteLine($"{firstNumber} - {secondNumber} = {subResult}");   

// Show the numbers as a multiplication equation, and the result
int mulResult = firstNumber * secondNumber;

Console.WriteLine($"{firstNumber} * {secondNumber} = {mulResult}");   

// Show the numbers as a division equation, and the result
double divResult = (double)firstNumber / secondNumber;

Console.WriteLine($"{firstNumber} / {secondNumber} = {divResult}");  