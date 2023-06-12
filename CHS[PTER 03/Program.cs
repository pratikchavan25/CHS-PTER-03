// See https://aka.ms/new-console-template for more information

// 3.Accept marks of 3 subjects physics ,chemistry , maths out of 100. Calculate percentage.
// Display grade as below.
// Percentage > 80% - Grade A
// Percentage > 70% - Grade B
// Percentage > 60% - Grade C
// Percentage < 60% - Grade D

using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;


Console.WriteLine("enter the marks of physics out of 100");
int physics_marks = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the marks of chemistry out of 100");
int chemistry_marks  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the marks of maths out of 100");
int maths_marks = Convert.ToInt32(Console.ReadLine());

int total_marks = physics_marks + chemistry_marks + maths_marks;

double percentage = (double) total_marks / 300 * 100;

Console.WriteLine("percentage"+percentage+"%");

string grade;

if (percentage > 80)
{
    grade = "A";
}
else if (percentage > 70)
{
    grade = "B";
}
else if (percentage > 60) 
{
    grade = "C";
}
else if (percentage < 60)
{
    grade = "D";
}
else
{
    grade = "E";
}
Console.WriteLine("grade = " + grade);
