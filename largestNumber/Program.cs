Console.WriteLine("Enter number#1: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number#2: ");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number#3: ");
int n3 = int.Parse(Console.ReadLine());

if(n1 > n2 && n1 > n3)
{
    Console.WriteLine($"{n1} is greatest");
} else if(n2 > n1 && n2 > n3)
{
    Console.WriteLine($"{n2} is greatest");
} else if(n3 > n1 && n3 > n2)
{
    Console.WriteLine($"{n3} is greatest");
} else if(n1 == n2 && n2 == n3)
{
    Console.WriteLine($"{n1} {n2} {n3} are equal");
}