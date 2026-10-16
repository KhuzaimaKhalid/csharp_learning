Console.Write("Enter digit: ");
int num = int.Parse(Console.ReadLine());
int original = num;
int reverse = 0;

while(num > 0)
{
    int digit = num % 10;
    reverse = reverse * 10 + digit;
    num = num / 10;
}

if(original == reverse)
{
    Console.WriteLine($"{original} is a Palindrome");
}
else
{
    Console.WriteLine($"{original} is not a Palindrome");
}