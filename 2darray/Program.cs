//Console.WriteLine("Enter the rows of an array: ");
//int n = int.Parse(Console.ReadLine());


//int[][] arr = new int[n][];

//for(int i=0; i<n; i++)
//{
//    arr[i] = new int[n];
//    for (int j = 0; j < n; j++)
//    {
//        Console.WriteLine($"input element arr[{i}][{j}]: ");
//        arr[i][j] = int.Parse(Console.ReadLine());
//    }
//}
//Console.WriteLine("===============================================================================");
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write($"{arr[i][j]}");
//        Console.Write(" ");
//    }
//    Console.WriteLine();
    //}

    // user input for both rows and cols

Console.Write("Enter the rows of an array: ");
int rows = int.Parse(Console.ReadLine());
int[][] arr = new int[rows][];

for (int i = 0; i < rows; i++)
{
    Console.Write($"Enter the no of cols for row#{i} : ");
    int cols = int.Parse(Console.ReadLine());
    arr[i] = new int[cols];
    for (int j = 0; j < cols; j++)
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

