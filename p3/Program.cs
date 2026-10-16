Console.WriteLine("How many students: ");
int n = int.Parse(Console.ReadLine());

int[] marks = new int[n];

for(int i = 0; i<n; i++)
{
    Console.WriteLine($"Enter marks for student {i+1}: ");
    marks[i] = int.Parse(Console.ReadLine());

}

int sum = 0, min = marks[0], max = marks[0];

foreach(int i in marks)
{
    sum += i;
    if (i < min) min = i;
    if (i > max) max = i;
}

double avg = (double)sum / n;

Console.WriteLine($"Sum:     {sum}");
Console.WriteLine($"Average: {avg:F2}");
Console.WriteLine($"Highest: {max}");
Console.WriteLine($"Lowest:  {min}");