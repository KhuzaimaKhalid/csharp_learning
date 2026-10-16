Console.WriteLine("Enter your marks (1-100) ");
int marks = int.Parse(Console.ReadLine());

String grade, feedback;

if(marks >= 90)
{
    grade = "A";
    feedback = "Excellent work!";
} else if(marks >= 80)
{
    grade = "B";
    feedback = "Good job";
} else if(marks >= 70)
{
    grade = "C";
    feedback = "good";
} else if(marks >= 60)
{
    grade = "D";
    feedback = "Satisfactory";
}else if(marks >= 50)
{
    grade = "E";
    feedback = "pass";
}
else
{
    grade = "F";
    feedback = "please retake the exam";
}

Console.WriteLine($"your marks is {marks} and your grade is {grade}");
Console.WriteLine($"feedback = {feedback}");