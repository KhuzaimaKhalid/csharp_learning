String[] names = { "khuzaima", "umer", "zohaib" };

foreach (String str in names)
{
    Console.WriteLine(str);
}
Console.Write("Enter the size of an array: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter the number on position {i}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("==== Array ====");

foreach (int num1 in arr)
{
    if (num1 == 10)
    {
        Console.WriteLine("10 is not allowed");
        break;
    }
    if (num1 == 20)
    {
        Console.WriteLine("20 is not allowed");
        continue;
    }
    Console.WriteLine(num1);
}

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Enter a multiplier: ");
int m = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine("===========================================");
    for(int j = 1; j <= m; j++)
    {
        Console.WriteLine($"{i}*{j} = {i * j}");
    }
}

Console.WriteLine("Ended");