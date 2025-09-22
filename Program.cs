// Program that detects if a year the user selects is a leap year
// Greet the user and ask for a name
Console.WriteLine("Hello");
Console.WriteLine("Pick a year");
Console.WriteLine();
Console.Write(">> ");
// Input the name and make it a number
int year = Convert.ToInt32(Console.ReadLine());
// Checks if the year is a leap year
if ((year % 4 == 0 && !(year % 100 == 0)) || (year % 4 == 0 && year % 100 == 0 && year % 400 == 0))
{
    Console.WriteLine($"{year} is a leap year!");
}
else
{
    Console.WriteLine($"{year} is not leap year!");
}