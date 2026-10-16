Console.Write("Enter your marks (1-100): ");
int marks = int.Parse(Console.ReadLine());

String grade;

grade = marks switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F"
};
Console.WriteLine($"Grade : {grade}");