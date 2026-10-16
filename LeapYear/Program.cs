Console.Write("Enter a year: ");
int n = int.Parse(Console.ReadLine());

if(n % 4 == 0)
{
    Console.WriteLine($"{n} is a leap year");
}
else
{
    Console.WriteLine($"{n} is not a leap year");
}
