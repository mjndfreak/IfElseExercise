

// I take a number imput from the user.
// Convert it to int and save it to number.
Console.Write("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

//Checks the number and outputs the number's status.
//First checks if the number is negative.
if (number < 0)
{
    Console.WriteLine("Invalid number!");
}

else  if (number < 10)
{
    Console.WriteLine("Number is smaller than 10.");
}

else if (number > 10)
{
    Console.WriteLine("Number is greater than 10.");
}

else
{
    Console.WriteLine("Number equals to 10.");
}