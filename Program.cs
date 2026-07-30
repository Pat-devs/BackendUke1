Console.Clear();


// conditionals

// 1. if - elseif - else

/*
if (condition) 
{
    do something
}
else if (some other condition)
{
    do something else
}
else 
{
    in all other cases dont do any of the above but do this instead
}
*/


// 2. switch

int age = 18;

// check if user is an adult ??
switch (age)
{
    case >= 18: // check if value (age) is above 18
        Console.WriteLine("User is an adult"); // do something
        break; // terminate the switch
    default:
        Console.WriteLine("User is not an adult");
        break;
}


