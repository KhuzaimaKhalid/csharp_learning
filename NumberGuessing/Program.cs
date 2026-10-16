Random r = new Random();
// while loop
//Console.Write("enter a number: ");
//int n = int.Parse(Console.ReadLine());

//int num = r.Next(1, 100);
//int noofguess = 1;
//while(n != num)
//{
//    noofguess++;
//    if (n > num)
//    {
//        Console.WriteLine("Number is greater");
//    }else if (n < num) {
//        Console.WriteLine("Number is smaller");

//    }
//    Console.Write("enter a number: ");
//     n = int.Parse(Console.ReadLine());
//}

//Console.WriteLine($"You guessed correctly in {noofguess} guesses");

int noofguesses = 1, n;
int num = r.Next(1, 100);
Boolean isGuessed = false;
do
{
    Console.Write("Enter a number: ");
    n = int.Parse(Console.ReadLine());
    noofguesses++;

    if(n > num)
    {
        Console.WriteLine("Number is greater");
    } else if(n < num)
    {
        Console.WriteLine("Number is smaller");
    } else if(n == num)
    {
        isGuessed = true;
    }


} while (!isGuessed);

Console.WriteLine($"You guessed correctly in {noofguesses} guesses");