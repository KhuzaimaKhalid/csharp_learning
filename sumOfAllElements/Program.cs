Console.WriteLine("Enter the rows of an array: ");
int rows = int.Parse(Console.ReadLine());
int[][] arr = new int[rows][];

for(int i = 0; i < rows; i++)
{
    Console.WriteLine("Enter the no of cols: ");
    int cols = int.Parse(Console.ReadLine());
    arr[i] = new int[cols];
    for(int j = 0; j < cols; j++)
    {
        Console.Write($"Input element arr[{i}][{j}] : ");
        arr[i][j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("===============================================================================");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < arr[i].Length; j++)
    {
        Console.Write($"{arr[i][j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("===============================================================================");
int sum = 0;
for(int i = 0; i< rows; i++)
{
    for(int j = 0; j< arr[i].Length; j++)
    {
        sum += arr[i][j];
    }
}

Console.WriteLine($"Sum of all elements = {sum}");

Console.WriteLine("sum of elements of each row");
for (int i = 0; i < rows; i++)
{
    int rowSum = 0;
    for (int j = 0; j < arr[i].Length; j++)
    {
        rowSum += arr[i][j];
    }
    Console.WriteLine($"Sum of all elements of  row#{i} = {rowSum}");
}

Console.WriteLine("sum of elements of each coloumn");
int maxCols = arr.Max(r => r.Length);
for (int j = 0; j < maxCols; j++)
{
    int colSum = 0;
    for (int i = 0; i < rows; i++)
    {
        if(j < arr[i].Length)
        {
            colSum += arr[i][j];
        }
    }
    Console.WriteLine($"Sum of all elements of  col#{j} = {colSum}");
}


for (int i = 0; i < rows; i++)
{
    int rowSum = 0;
    for (int j = 0; j < arr[i].Length; j++)
    {
        rowSum += arr[i][j];
    }
    int avg = rowSum / arr[i].Length;
    Console.WriteLine($"Sum of all elements of  row#{i} = {rowSum}");
}
