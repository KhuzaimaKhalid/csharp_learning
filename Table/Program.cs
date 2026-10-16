Console.Write("Enter the number for table: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Enter the multiplier: ");
int n = int.Parse(Console.ReadLine());
int result = 1;
for(int i = 1; i <= n; i++)
{
    result = num * i;
    Console.WriteLine($"{num} X {i} = {result}");
}