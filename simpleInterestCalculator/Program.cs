Console.WriteLine("Enter principal amount: ");
int p = int.Parse(Console.ReadLine());
Console.WriteLine("Enter annual interest: ");
int r = int.Parse(Console.ReadLine());
Console.WriteLine("Enter time in years: ");
int t = int.Parse(Console.ReadLine());

int si = (p * r * t) / 100;
int time = p + si;
Console.WriteLine($"Simple Interest: {si}");
Console.WriteLine($"Total TIme Taken: {time}");