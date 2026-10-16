Console.WriteLine("Enter units: ");
int n = int.Parse(Console.ReadLine());
int bill;
if(n <= 100)
{
    bill = n * 10;
    Console.WriteLine($"bill: {bill}");
} else if(n > 100 && n <= 200)
{
    bill = n * 15;
    Console.WriteLine($"bill: {bill}");
} else if( n > 200)
{
    bill = n * 20;
    Console.WriteLine($"bill: {bill}");
}
