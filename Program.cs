// Program that detects if a year the user selects is a leap year
// Greet the user and ask for a name
using System.Diagnostics;
int years = 0;
bool tried = false;
while (tried == false)
{
    Console.WriteLine("Hello");
    Console.WriteLine("Pick a year");
    Console.WriteLine();
    Console.Write(">> ");
    // Input the name and make it a number
    string year = Console.ReadLine() + "";
    if (int.TryParse(year, out int result))
        {
            years = Convert.ToInt32(year);
            tried = true;
        }
    else
        {
            Console.WriteLine("Invalid input.");
        }
}
// Checks if the year is a leap year
if ((years % 4 == 0 && !(years % 100 == 0)) || (years % 4 == 0 && years % 100 == 0 && years % 400 == 0))
{
    Console.WriteLine($"{years} is a leap year!");
}
else
{
    Console.WriteLine($"{years} is not leap year!");
}
