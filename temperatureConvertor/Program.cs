Console.WriteLine("1. Celsius to Fahrenheit");
Console.WriteLine("2. Fahrenheit to Celsius");
Console.WriteLine("Enter your choice: ");
int n = int.Parse(Console.ReadLine());
if(n == 1)
{
    Console.WriteLine("Enter Celsius: ");
    int c = int.Parse(Console.ReadLine());
    int f = (c * (9 / 5)) + 32;
    Console.WriteLine($"Temperature in fahrenheit: {f}");
} else if(n == 2)
{
    Console.WriteLine("Enter fahrenheit: ");
    int f = int.Parse(Console.ReadLine());
    int c = (f - 32) * (5 / 9);
    Console.WriteLine($"Temperature in celsius: {c}");
}
else
{
    Console.WriteLine("please enter valid input");
}
