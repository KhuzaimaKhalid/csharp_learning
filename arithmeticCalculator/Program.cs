
Boolean exit = false;
do
{
    Console.Write("Enter a number#1 : ");
    int n1 = int.Parse(Console.ReadLine());
    Console.Write("Enter a number#2 : ");
    int n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter your choice: ");
    int n = int.Parse(Console.ReadLine());
    switch (n)
    {
        case 1:
            int result = n1 + n2;
            Console.WriteLine(result);
            break;
        case 2:
            int result1 = n1 - n2;
            Console.WriteLine(result1);
            break;
        case 3:
            int result2 = n1 * n2;
            Console.WriteLine(result2);
            break;
        case 4:
            int result3 = n1 / n2;
            Console.WriteLine(result3);
            break;
        case 5:
            Console.WriteLine("Exiting............");
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid input!");
            break;
    }

} while (!exit);